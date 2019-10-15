using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayPablo = new ArrayList();
            Random r = new Random();
            
            int numero = 0;
            for(int i = 0; i < 50; i++)
            {
                numero = r.Next(0, 50);
                arrayPablo.Add(numero);
            }

            foreach (int i in arrayPablo)
            {
                Console.WriteLine(i);
            }

            arrayPablo.Sort();

            foreach(int i in arrayPablo)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
