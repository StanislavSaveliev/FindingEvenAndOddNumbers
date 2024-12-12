using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;            
            a = int.Parse(Console.ReadLine());
            int b = a % 2;
            bool resulr = b==0 ;

            if (resulr)
            {
                Console.WriteLine("Ваше число является четным");
            }

            else
            {
                Console.WriteLine("Ваше число не является четным");
            }
              
        }
    }
}
