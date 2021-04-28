using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public interface IManoKlase
    {
       int ManoKintamasis { get; set; }
    }
    public class ManoKlase : IManoKlase
    {
        private int a;
        public int MyProperty { get; set; } //get naudojama kai prop pakvieciamas set kai prop irasome kokia reiksme
        public int ManoKintamasis { get; set; }

        private void IrasytiProperty(int a)
        {
            MyProperty = a;
        }

    }
    public class ManoKlase1 : ManoKlase
    {
        public int MyProperty1 { get; set; }
    }
}
