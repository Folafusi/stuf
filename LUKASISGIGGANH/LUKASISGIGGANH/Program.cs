using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jj
{
	class PL
	{
		static void Main(string[] args)
		{
			Console.WriteLine("guess number");
			float num = float.Parse(Console.ReadLine());
            {
				
				if (num == 69)
				{
					Console.WriteLine("The number is fine");
				}
				if (num >= 2 && num <= 999999)
				{
					Console.WriteLine("Wrong number better next time");
					Console.WriteLine("Try agian");
					
                }
            }
			Console.WriteLine("choose what you are");
            string Thing = Console.ReadLine();
			Console.WriteLine("Now Who");
            string name = Console.ReadLine();
            {
				
				Console.WriteLine("You are {0} {1}", Thing, name);
            }
		}
	}
}



