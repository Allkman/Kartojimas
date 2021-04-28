using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class Kamuolys
    {
        Spalva color = new Spalva();
        private int ballSize = 7;
        private int throwCount = 0;
        public Kamuolys()
        {

        }
        public void Mesti()
        {
            throwCount += 1;
        }
        public void Susprogdinti()
        {
            ballSize = 0;
        }
    }
}
