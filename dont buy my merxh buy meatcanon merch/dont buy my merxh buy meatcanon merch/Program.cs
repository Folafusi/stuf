using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number");
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            for (int i = 0; i <= x; i++)
                y = y + i;
            Console.WriteLine(y);
                Console.ReadKey();
        }
    }
}



