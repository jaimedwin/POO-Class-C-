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
        static int[,] m;
        static int n;

        

        void ReaderAndRandom()
        {
            Console.WriteLine("Leer matriz:");
            for (int i = 0; i <= (n - 1); i++) {
                for (int j = 0; j <= (n - 1); j++) {
                    if (i == j) {
                        int res = int.Parse(Console.ReadLine());
                        m[i, j] = res;
                    } else {
                        int res = new Random().Next(1, 10);
                        m[i, j] = res;
                    }

                }

            }
        }


        static void Main()
        {
            Console.WriteLine("Tamaño de la Matriz:");
            n = int.Parse(Console.ReadLine());
            Program r = new Program();
            m = new int[n, n];
            r.ReaderAndRandom();
            r.ShowMatriz();
            Console.ReadKey();
        }

        void ShowMatriz()
        {
            Console.WriteLine("MostrarMatriz");
            for (int i = 0; i <= (n - 1); i++)
            {
                for (int j = 0; j <= (n - 1); j++)
                {
                    Console.WriteLine("Posicion m[{0},{1}] = {2}", i, j, m[i, j]);
                }

            }
            
        }
        

        
    }
}
