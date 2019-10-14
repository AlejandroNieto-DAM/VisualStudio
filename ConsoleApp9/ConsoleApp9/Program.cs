using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    
    class Program
    {
        static void Main(string[] args)
        {

            String a = "";
            String b = "";

            int x = 0;
            int y = 0;
            int division = 0;

            try
            {
                Console.Write("Introduce un numero: ");
                x = Convert.ToInt32(a = Console.ReadLine());

                Console.WriteLine("\nIntroduce otro numero: ");
                y = Convert.ToInt32(b = Console.ReadLine());

                division = x / y;
                Console.WriteLine("El resultado de la divison --> ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

            Console.ReadKey();

        }
    }
}
