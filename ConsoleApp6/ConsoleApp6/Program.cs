using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = "";
            int contadorDeSietes = 0;

            Console.WriteLine("Introduce un numero!");
            cadena = Console.ReadLine();
            
            foreach(char a in cadena)
            {
                if(a == '7')
                {
                    contadorDeSietes++;
                }
            }

            Console.WriteLine("Has introducido: " + contadorDeSietes + " veces el numero 7");
            contadorDeSietes = 0;
            int i = 0;
            char letra;
            int length = cadena.Length;

            do
            {
                letra = cadena[i];
                if(letra == '7')
                {
                    contadorDeSietes++;
                }
                i++;
            } while (i <  length);

            Console.WriteLine("Has introducido: " + contadorDeSietes + " veces el numero 7");

            Console.ReadKey();
         
        }
    }
}
