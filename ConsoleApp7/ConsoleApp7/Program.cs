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

            for (int i = 0; i < 8; i++)
            {

                for(int j = 0; j < 8; j++)
                {

               
                    if (i % 2 == 0 && (i != x - 1 && j != y - 1))
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("N");
                        }
                        else
                        {
                            Console.Write("B");
                        }
                    }
                    else if ((i == x - 1 && j == y - 1))
                    {

                        Console.Write("*");

                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("B");
                        }
                        else
                        {
                            Console.Write("N");
                        }

                    }

                    x++;
                    y++;

                    


                }

                Console.WriteLine();
                
            }



            Console.ReadKey();
        }
    }
}
