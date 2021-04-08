using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionWebApp.Models.ViewModels
{
    public class MainModel
    {        
        public CompositionContext db { get; set; }
        public string Key { get; set; }
        public int? SelectedId { get; set; }
    }
}
