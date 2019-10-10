using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            String a = "";
            String b = "";

            int x = 0;
            int y = 0;

            Console.WriteLine("Introduce la posicion x del alfil: ");
            a = Console.ReadLine();
            x = Convert.ToInt32(a);

            Console.WriteLine("Introduce la posicion y del alfil: ");
            b = Console.ReadLine();
            y = Convert.ToInt32(b);

            int abs1 = 0;
            int abs2 = 0;

            String cadena = "";

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {

                    abs1 = Math.Abs(x - i);
                    abs2 = Math.Abs(y - j);

                    if ((x != i || y != j) && (abs1 != abs2))
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                cadena = cadena + "B";
                            }
                            else
                            {
                                cadena = cadena + "N";
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                cadena = cadena + "N";
                            }
                            else
                            {
                                cadena = cadena + "B";
                            }
                        }
                    }
                    else if ((abs1 == abs2))
                    {
                        cadena = cadena + "*";
                    }

                }


                Console.WriteLine(cadena);

                cadena = "";
            }



            Console.ReadKey();
        }
    }
}
