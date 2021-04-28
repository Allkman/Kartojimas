using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class Spalva
    {
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        public Spalva(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public Spalva()
        {
            R = G = B = 255;
        }

        public void SetColors(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
        public byte GetGreyScale()
        {
            var greyScale = (R + G + B) / 3;
            return (byte)greyScale;
        }
    }
}
