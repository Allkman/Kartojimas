using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    public interface IZodisKitaip
    {
        string ZodisBeBalsiu();
        string ZodisBePriebalsiu();
        string ZodisSuPakeistomisBalsemis(char letter);
        string ZodisSuPakeistomisPriebalsemis(int num01);
    }
}
