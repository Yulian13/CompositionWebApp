using System;
using System.Collections.Generic;
using System.Drawing;

namespace CompositionWebApp.Models
{
    public partial class Photo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string RightKey { get; set; }
        public int? CompositionId { get; set; }

        public Composition Composition { get; set; }

        public byte[] GetImage(string Key)
        {
            //return Image;
            return Librari.imageToByteArray(new NewImage(this).DeShifrovkaImage(Key));
        }
    }
}
