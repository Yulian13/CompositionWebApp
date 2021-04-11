using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CompositionWebApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CompositionWebApp.Models.ViewModels;

namespace CompositionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private const string KeyPass = "pass";
        private const string KeySelecdId = "SelectedId";
        CompositionContext db;

        public HomeController(CompositionContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Password()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Password(string Key)
        {
            HttpContext.Session.SetString(KeyPass, Key);
            HttpContext.Session.SetInt32(HomeController.KeySelecdId, -1);

            MainModel model = GetMainObjectcs();
            return View("Main", model);
        }

        [HttpGet]
        public IActionResult Main()
        {            
            HttpContext.Session.SetInt32(HomeController.KeySelecdId, -1);

            MainModel model = GetMainObjectcs();
            return View(model);
        }

        [HttpPost]
        public IActionResult Main(int id = -1)
        {
            HttpContext.Session.SetInt32(HomeController.KeySelecdId, id);

            MainModel model = GetMainObjectcs();
            return View(model);
        }


        public IActionResult Composition()
        {
            MainModel model = GetMainObjectcs();
            return View("View", model);
        }

        [HttpPost]
        public IActionResult Galerea(int id)
        {
            GalereaModel objectcs = new GalereaModel(GetMainObjectcs());
            Composition composition = db.Compositions.Find(objectcs.SelectedId);
            objectcs.PhotoId = id;

            if (id == composition.IdFirstPhoto) objectcs.Maybe = 1;
            else if (id == composition.IdFirstPhoto + composition.NumberPhotos - 1) objectcs.Maybe = 2;

            if(composition.NumberPhotos > 12)
            {
                int position = (int)(id - composition.IdFirstPhoto);

                if (position < 6) objectcs.MinId = 0;
                else if ((composition.NumberPhotos - (position + 1)) <= 6) objectcs.MinId = composition.NumberPhotos - 12 - 1;
                else objectcs.MinId = position - 6;

                if (position < 6) objectcs.MaxId = 12;
                else if ((composition.NumberPhotos - (position + 1)) <= 6) objectcs.MaxId = composition.NumberPhotos;
                else objectcs.MaxId = position + 6;
            }
            else
            {
                objectcs.MinId = 0;
                objectcs.MaxId = composition.NumberPhotos;
            }

            return View(objectcs);
        }


        MainModel GetMainObjectcs(string key = null, int? selectId = null)
        {
            MainModel mainObjectcs = new MainModel()
            {
                Key = key ?? HttpContext.Session.GetString(KeyPass),
                SelectedId = (selectId == null || selectId < 0) ? HttpContext.Session.GetInt32(KeySelecdId) : selectId,
                db = db
            };
            return mainObjectcs;
        }
        public async Task<ActionResult> GetImage(Photo photo)
        {
            try
            {
                var image = await Task.Run(() => photo.GetImage(HttpContext.Session.GetString(KeyPass)));
                return new FileContentResult(image, "image/jpg");
            }
            catch (Exception)
            {
                return File("~/Images/empty.jpg", "image/jpg");
            }
        }
        public async Task<ActionResult> GetedImage(int id)
        {
            return await GetImage(db.Photos.Find(id));
        }

        public async Task<ActionResult> GetFirstImage(int id)
        {
            try
            {
                int? Id = db.Compositions.Find(id).IdFirstPhoto;
                var image = await Task.Run(() => db.Photos.Find(Id).GetImage(HttpContext.Session.GetString(KeyPass)));
                return new FileContentResult(image, "image/jpg");
            }
            catch (Exception)
            {
                return File("~/Images/empty.jpg", "image/jpg");
            }
        }
    }
}
