using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetor - Array unidimensional
            //int[] numeros = new int[5];

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 50;
            //numeros[4] = 60;

            //numeros[2] = 55;

            //string[] letras =
            //{
            //    "adriano",
            //    "abner",
            //    "caixa",
            //    "amanda",
            //    "suzi"

            //};
            #endregion


            #region Matriz - Array Bidimensional
            int[,] numero = new int[2, 3];
            numero[0, 0] = 10;
            numero[0, 1] = 20;
            numero[0, 2] = 30;

            numero[1, 0] = 40;
            numero[1, 1] = 50;
            numero[1, 2] = 60;

            string[,] nomes = {

                {"Adriano", "Abner", "Ana" },
                {"Ariadner", "Luiz", "Vania" }
            };
            #endregion

            Console.Write("[" + nomes[0,0] + "]");
            Console.Write("[" + nomes[0,1] + "]");
            Console.Write("[" + nomes[0,2] + "]");
            Console.WriteLine();
            Console.Write("[" + nomes[1,0] + "]");
            Console.Write("[" + nomes[1,1] + "]");
            Console.Write("[" + nomes[1,2] + "]");
            Console.ReadKey();
        }
    }
}
