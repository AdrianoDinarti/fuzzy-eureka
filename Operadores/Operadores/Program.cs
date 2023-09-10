using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operadores Matemáticos 
            //int num1 = 10;
            //int num2 = 20;
            //int resultado = num1 + num2;

            #endregion


            #region precedência de operadores
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = 4;
            //int resto = (num1 + num2) * num3;
            #endregion


            #region Operadores de incremento decremento 
            // int num1 = 10;
            //num1 = num1 + 1;
            //num1++; // incremento
            //++num1; // decremento
            //--num1; // decremento
            //num1--; // incremento 
            #endregion


            #region Operador de concatenação
            //string nome = "Adriano ";
            //string sobreNome = "Dinarti";
            //string nomeCompleto = nome  +  sobreNome + " " + 1998;
            #endregion

            #region Operadores de atribuição
            //int num1 = 20;
            ////num1 = num1 + 10;
            ////num1 += 10;
            ////num1 -= 10;
            ////num1 *= 10;
            ////num1 /= 2;
            //num1 %= 3;
            #endregion


            #region Operadores de igualdade
            //bool resposta = 100 == 20;
            //bool resposta2 = 100 != 100;
            //bool resposta3 = 100 == 100;
            //bool resposta4 = (100 / 2) != (100 * 100);
            //string nome = "Adriano";
            //bool resposta5 = nome != "Adriano";
            #endregion

            #region Operadores relacionais
            //bool resposta = 100 < 50;
            //bool resposta2 = 100 > 50;
            //bool resposta3 = 100 <= 50;
            //bool resposta4 = 100 >= 50;
            #endregion


            #region Operadores lógicos
            //bool num1 = 100 < 50;
            //bool num2 = 100 == 100;
            //bool final = num1 && num2; // && == and = Utilizado quando desejamos que as duas expressões sejam verdadeiras
            //bool final2 = num1 || num2; // || == or = Utilizando quando precisamos que pelo menos uma das expressões seja verdadeira
            #endregion


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
