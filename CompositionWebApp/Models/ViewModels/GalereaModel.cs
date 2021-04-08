using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionWebApp.Models.ViewModels
{
    public class GalereaModel
    {
        public GalereaModel(MainModel model)
        {
            Key = model.Key;
            SelectedId = model.SelectedId;
            db = model.db;
        }

        public CompositionContext db { get; set; }
        public string Key { get; set; }
        public int? SelectedId { get; set; }
        public int PhotoId { get; set; }
        public int Maybe { get; set; }
        public int MinId { get; set; }
        public int MaxId { get; set; }

    }
}
