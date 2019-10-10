using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "";
            String b = "";

            a = Console.ReadLine();
            b = Console.ReadLine();

            if (Convert.ToInt32(a) % 2 == 0 && Convert.ToInt32(b) % 2 == 0)
            {
                Console.WriteLine("Ambos son pares");
            }
            else if (Convert.ToInt32(a) % 2 != 0 && Convert.ToInt32(b) % 2 != 0)
            {
                Console.WriteLine("Ambos son impares");
            }
            else
            {
                Console.WriteLine("Uno es par y otro impar");
            }

            Console.ReadKey();
        }
    }
}
