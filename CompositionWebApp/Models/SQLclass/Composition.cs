using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CompositionWebApp.Models
{
    public partial class Composition
    {
        public Composition()
        {
            Photos = new List<Photo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberPhotos { get; set; }
        public int? IdFirstPhoto { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public string GetDeShiffovkaName(string pass)
        {
            try
            {              
                return Librari.DeShifrovka(Name, pass);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetDeShiffovkaName(string pass, int leng)
        {
            try
            {
                string name = GetDeShiffovkaName(pass);
                if (name.Length > leng) { name = name.Remove(leng) + "..."; }
                return name;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
