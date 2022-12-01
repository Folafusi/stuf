using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruh




{
    class gay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej poloměr kruhu (cm): ");
            float r = float.Parse(Console.ReadLine());
            float pi = 3.14f;

            float o = 2 * pi * r;

            double S = pi * r * r;
            Console.WriteLine("S= {0} o= {1}", S, o);            
            Console.ReadKey();
        }

    }
   

}
