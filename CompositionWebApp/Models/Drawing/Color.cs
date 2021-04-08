using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionWebApp.Models
{
    public class Color
    {
        public byte A {get;set;}
        public byte R {get;set;}
        public byte G {get;set;}
        public byte B {get;set;}

        public Color()
        {
            A = 0;
            R = 0;
            G = 0;
            B = 0;
        }

        public static Color FromArgb(byte A, byte R, byte G, byte B)
        {
            Color color = new Color();

            color.A = A;
            color.R = R;
            color.G = G;
            color.B = B;

            return color;
        }

        public static Color FromArgb(byte R, byte G, byte B)
        {
            Color color = new Color();

            color.R = R;
            color.G = G;
            color.B = B;

            return color;
        }

    }
}
