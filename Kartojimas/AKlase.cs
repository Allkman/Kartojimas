using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name): base(name)
        {

        }
        public override string NameMetodas()
        {
            var sb = new StringBuilder();
            List<char> visosBalses = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var raide in Name)
            {
                sb.Append(visosBalses.Contains(raide) ? (int)raide : raide);
            }
            return sb.ToString();

        }
        public override int NameKodas(int asmKodas)
        {
            
        }


    }
}
