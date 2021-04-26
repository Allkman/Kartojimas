using System;

namespace Kartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var aklase = new AKlase("mama");
            var nameMetodas = aklase.NameMetodas();
            Console.WriteLine(nameMetodas);
        }
    }
}
