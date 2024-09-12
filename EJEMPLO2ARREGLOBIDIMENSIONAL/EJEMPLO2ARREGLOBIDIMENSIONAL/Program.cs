using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO2ARREGLOBIDIMENSIONAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int f, c, sum = 0;

            Console.WriteLine("Programa usando arreglos bidimensionales");
            Console.WriteLine("Digita los datos del arreglo");
            //Llenado el arreglo

            for (f = 0; f < 3; f++) 
            {
                for (c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                }
            }
            //Imprimiendo el arreglo

            Console.WriteLine();
            Console.WriteLine("Los elementos del arreglo son : ");
            Console.WriteLine();

            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {                  
                    Console.Write(" "+ tabla1[f, c]);
                    sum += tabla1[f, c];

                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("La suma de los elementos del arreglo es: " + sum);

            Console.ReadKey();
        }
    }
}
