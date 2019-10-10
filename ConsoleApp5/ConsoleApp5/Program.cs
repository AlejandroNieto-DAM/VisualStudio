using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int aleatorio = r.Next(0, 20);
            int contador = 0;
            //int aleatorio = 5;
            String numero = "";

            Console.WriteLine("");

            do
            {
                do
                {
                    numero = "";
                    Console.WriteLine("Introduce un numero entre 0 - 20: ");
                    numero = Console.ReadLine();
                    Console.WriteLine(numero);
                } while (Convert.ToInt32(numero) > 20 || Convert.ToInt32(numero) < 0);

                Console.Clear();

                if (Convert.ToInt32(numero) != aleatorio)
                {
                    if (Convert.ToInt32(numero) > aleatorio)
                    { 
                        Console.WriteLine("El numero que has introducido es mayor!!! ");
                    } else
                    {
                        Console.WriteLine("El numero que has introducido es menor!!! ");
                    }

                    
                } else if (Convert.ToInt32(numero) == aleatorio)
                {
                    Console.WriteLine("Premio!! Has acertado!!");
                }

                contador++;

                if(contador == 5)
                {
                    Console.WriteLine("Se han acabado las oportunidades!!");
                } else if (contador < 5 && Convert.ToInt32(numero) != aleatorio)
                {
                    int intentos = 5 - contador;
                    Console.WriteLine("Tienes " + intentos + " intentos!!");
                }

                

            } while (contador < 5 && Convert.ToInt32(numero) != aleatorio);

            Console.ReadLine();

        }
    }
}
