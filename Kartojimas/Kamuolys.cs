using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class Kamuolys : Zaislas
    {
        Spalva spalva = new Spalva();        

        public Kamuolys()
        {

        }
        
        
        public override void Mesti()
        {
            ThrowCount += 1;
        }
    }
}
