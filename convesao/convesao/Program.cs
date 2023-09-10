using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convesao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implicita
            //byte nume1 = 100; // 8 bits, de 0 a 255
            //ushort nume2; // 16 bits, 0 a 65.535
            //nume2 = nume1;
            #endregion


            #region Conversão explicita
            //ushort numero1 = 500;
            //byte numero2 = (byte)numero1; // Conversão explicita pode o correr perda de dados.

            //float numero3 = 2500.900f;
            //int numero4 = (int)numero3;

            //char letra = (char)97;
            #endregion

            #region Método Parse
            //string txtnumero = "1998";
            //int numero = int.Parse(txtnumero); // metodo Parse é conversor.  
            #endregion

            #region Método Converte
            string texto = Convert.ToString(2500); // convert qualquer tipo de valor
            double num1 = Convert.ToDouble(false);
            int num2 = Convert.ToInt32('C');
            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
