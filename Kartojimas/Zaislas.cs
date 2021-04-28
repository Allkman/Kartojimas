using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public abstract class Zaislas
    {
        public int Size { get; set; }
        public int ThrowCount { get; set; }

        public abstract void Mesti();
        public virtual void Susprogdinti()
        {
            Size = 0;
        }
    }
}
