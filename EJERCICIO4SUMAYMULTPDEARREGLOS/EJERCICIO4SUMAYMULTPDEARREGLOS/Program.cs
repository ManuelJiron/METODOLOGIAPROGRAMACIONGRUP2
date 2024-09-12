using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4SUMAYMULTPDEARREGLOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Utilice un arreglo de un subíndice para resolver el siguiente problema. Una empresa le paga a su personal de ventas en base a comisión.
              Los vendedores reciben $200 por semana más 9 % de sus ventas brutas de dicha semana. Por ejemplo, un vendedor que vende $3000 en ventas
              brutas es una semana recibe $200 más 9% de 3000, o sea un total de $470. Escriba un programa en C# (utilizando un arreglo de contadores)
              que determine cuántos de los vendedores ganaron salarios en cada uno de los rangos siguientes (suponiendo que el salario de cada vendedor
              se trunca a una cantidad entera):
             
            1.	$200-$299
            2.	$300-$399
            3.	$400-$499 4. $500-$599 5. $600-$699 6. $700-$799
            1.	7. $800-$899
            2.	8. $900-$999
            3.	9. $1000 o superior */

            int number = 0;

            Console.WriteLine("Digite la cantidad de personal a analizar");
            number = int.Parse(Console.ReadLine());

            double[] totalSells = new double[number];
            double[] comision = new double[number];
            int c1=0, c2=0, c3=0, c4=0, c5=0, c6=0, c7=0, c8=0, c9 = 0;


            Console.WriteLine("Digite las ventas brutas de cada trabajador");
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                totalSells[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Los salarios con comisiones son los siguientes: ");

            for (int i = 0; i < number; i++)
            {
                comision[i] = 200 + (totalSells[i] * 0.09);

                Console.Write(comision[i] + ",");
                
            }
            Console.WriteLine("");
            for (int i = 0; i < number; i++)
            {
                if (comision[i] >= 200 && comision[i] <= 299)
                {
                    c1++;
                  
                } else if (comision[i] >= 300 && comision[i] <= 399)
                {
                    c2++;
                }
                else if (comision[i] >= 400 && comision[i] <= 499)
                {
                    c3++;
                }
                else if (comision[i] >= 500 && comision[i] <= 599)
                {
                    c4++;
                }
                else if (comision[i] >= 600 && comision[i] <= 699)
                {
                    c5++;
                }
                else if (comision[i] >= 700 && comision[i] <= 799)
                {
                    c6++;
                }
                else if (comision[i] >= 800 && comision[i] <= 899)
                {
                    c7++;
                }
                else if (comision[i] >= 900 && comision[i] <= 999)
                {
                    c8++;
                }
                else if (comision[i] >= 1000)
                {
                    c9++;
                }
                else
                {
                    Console.WriteLine("No se encuentra entre los rangos");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Resultados:");
            Console.WriteLine();
            Console.WriteLine("Se encuentran entre $200-$299: " + c1);
            Console.WriteLine("Se encuentran entre $300-$399: " + c2);
            Console.WriteLine("Se encuentran entre $400-$499: " + c3);
            Console.WriteLine("Se encuentran entre $500-$599: " + c4);
            Console.WriteLine("Se encuentran entre $600-$699: " + c5);
            Console.WriteLine("Se encuentran entre $700-$799: " + c6);
            Console.WriteLine("Se encuentran entre $800-$899: " + c7);
            Console.WriteLine("Se encuentran entre $900-$999: " + c8);
            Console.WriteLine("Se encuentran entre $1000 o superior: " + c9);



            Console.ReadKey();
        }
    }
}
