/* 
 * Nombre: Jaime Edwin Arciniegas Garcia
 * Fecha:26-08-2017
 * Descripcion: Registra los datos de consola para i = j y genera el resto de campos aleatorio. para una matriz de n tamaño y finalmente imprime.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        
        static void Main()
        {
            int[,] m;
            int n;
            Console.WriteLine("Tamaño de la Matriz:");
            n = int.Parse(Console.ReadLine());
            m = new int[n, n];

            Console.WriteLine("Leer matriz:");
            for (int i = 0; i <= (n-1); i++)
            {
                for (int j = 0; j <= (n-1); j++)
                {
                    int res;
                    if (i == j) // Si la fila es igual a la columna
                    {
                        
                        res = int.Parse(Console.ReadLine()); 
                    }
                    else
                    {
                        
                        res = new Random().Next(10, 100);
                    }
                    m[i, j] = res; // Se asgina el valor cargado de consola, Si no se asigna un valor aleatorio
                }

            }

            Console.WriteLine("MostrarMatriz"); // Inicia el proceso de mostrar matriz
            for (int i = 0; i <= (n - 1); i++)
            {
                for (int j = 0; j <= (n - 1); j++)
                {
                    Console.WriteLine("Posicion m[{0},{1}] = {2}", i, j, m[i, j]);
                }

            }
            Console.ReadKey();

        }
    }
}
