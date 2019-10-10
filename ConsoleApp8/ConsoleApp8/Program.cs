using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int mes = 0;
            int anio = 0;

            Console.Write("Dime el numero de un mes --> ");
            String a = Console.ReadLine();
            mes = Convert.ToInt32(a);

            Console.Write("\nDime un año --> ");
            String b = Console.ReadLine();
            anio = Convert.ToInt32(b);

            switch (mes)
            {
                case 1: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 2:
                    if ((anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0))
                    {
                        Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 29 dias!");
                    }
                    else
                    {
                        Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 28 dias!");
                    }

                    break;

                case 3: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 4: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 30 dias!"); break;
                case 5: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 6: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 30 dias!"); break;
                case 7: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 8: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 9: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 30 dias!"); break;
                case 10: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;
                case 11: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 30 dias!"); break;
                case 12: Console.WriteLine("El mes " + mes + " del año " + anio + " tiene 31 dias!"); break;

            }

            Console.ReadKey();
        }

    }
}
