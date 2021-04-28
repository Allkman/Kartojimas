using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public class BKlase : BaseClass, IZodisKitaip
    {
        private readonly List<char> balses = "aeiou".ToList();
        public BKlase(string name) : base(name)
        {

        }

        public override int NameKodas(int asmKodas)
        {
            int kodas = 0;
            foreach (var symbolis in Name)
            {
                kodas += (int)symbolis - asmKodas;
            }
            return kodas;
        }

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }

        public string ZodisBeBalsiu()
        {
            
            return Name.Where(r => !balses.Contains(r)).ToString(); //new string(Name.Where(r => !balses.Contains(r)).ToArray());
        }

        public string ZodisBePriebalsiu()
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisBalsemis(char letter)
        {
            throw new NotImplementedException();
        }

        public string ZodisSuPakeistomisPriebalsemis(int num01)
        {
            throw new NotImplementedException();
        }
    }
}
