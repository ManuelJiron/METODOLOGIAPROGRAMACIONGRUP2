using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLODEARREGLOS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tam = 10;
            int[] numeros = new int[tam];
            int cp = 0, ci = 0;

            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();

            for (int i = 0; i < tam; i++) 
            {
                Console.WriteLine("Ingresa un numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Datos del arreglo: ");
            Console.WriteLine();

            for (int i = 0; i < tam; i++) 
            {
                Console.Write(numeros[i] + ",");
                if (numeros[i] % 2 == 0)
                {
                    cp++;
                } else
                {
                    ci++;
                }
            }

            Console.WriteLine("Cantidad de Pares: " + cp);
            Console.WriteLine("Cantidad de impares: "+ ci);

            Console.ReadKey();
        }
    }
}
