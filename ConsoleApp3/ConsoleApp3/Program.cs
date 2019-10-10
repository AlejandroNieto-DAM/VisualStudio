using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "";
            String b = "";

            a = Console.ReadLine();
            b = Console.ReadLine();

            if(Convert.ToInt32(a) > Convert.ToInt32(b))
            {
                Console.WriteLine("El mayor es " + a);
            } else if (Convert.ToInt32(a) < Convert.ToInt32(b))
            {
                Console.WriteLine("El mayor es " + b);
            } else
            {
                Console.WriteLine("Son iguales");
            }

            Console.ReadKey();
        }
    }
}
