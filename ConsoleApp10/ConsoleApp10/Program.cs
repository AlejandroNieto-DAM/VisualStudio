using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] antonio = {"pepito", "pepino", "antonio", "carlos", "raul", "jopegras", "noelia", "mateo", "diccionario", "godofredo"};
            int diferencia = 0;
            String auxiliar = "";
            for(int i = 0; i < antonio.Length; i++){
                for(int j = 0; j < antonio.Length; j++){
                    diferencia = string.Compare(antonio[i], antonio[j]);
                    if(diferencia == -1){
                        auxiliar = antonio[i];
                        antonio[i] = antonio[j];
                        antonio[j] = auxiliar;
                    }
                }
            }

            for(int i = 0; i < antonio.Length; i++)
            {
                Console.WriteLine(antonio[i]);
            }

            Console.ReadKey();
        }
    }
}
