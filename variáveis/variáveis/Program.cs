using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variáveis
{
    internal class Program
    {
        enum Notas
        {
            Minimo = 10, 
            Media = 20, 
            Maximo = 90
        }

        struct Pessoa //estrutura
        {
            // public = modificadores de acesso
            public string nome;
            public int idade;
            public float altura;
        }

        static void Main(string[] args)
        {
            #region Numericas integral

            //// integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero = 50;
            //numero = 100;
            #endregion

            #region Números reais

            //float real1 = 100.98f;
            //double real2 = 12000.89;
            //decimal real3 = 12309.90m;

            //double valor;
            //valor = real1;
            #endregion

            #region Caracteres
            //char letra = 'a';
            //char codigo = '\u0041';
            //char escape = '\n';
            #endregion

            #region Número booleanos 

            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String

            //string texto = @"Adriano Dinarti\n 1998";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipos de Var
            //var valor = 100;
            //valor = 10;
            //valor = "Adriano"; //Não tem como atribuir valor diferente daquele que foi definido 
            #endregion

            #region Tipo object
            //object obj = 100; // Ela é a base para todos os valores
            //obj = false;
            //obj = "Adriano";
            //obj = 12.90;
            #endregion

            #region Constante
            //const double pi = 3.1415; // número pi é uma constante, nunca muda
            //pi = 2.90;
            //const string nome = "Adriano";
            #endregion

            #region Enumeração
            //Notas notasalunos = Notas.Minimo;
            //Notas notasaluno = Notas.Media;
            //Notas notasalun = Notas.Maximo;
            #endregion

            #region Estrutura
            Pessoa p1 = new Pessoa();
            p1.nome = "Adriano";
            p1.idade = 24;
            p1.altura = 1.80f;

            Pessoa p2 = new Pessoa()
            {
                nome = "Ana",
                idade = 6,
                altura = 1.60f
            };
            p1.nome = "Abner"; // Modifiquei o valor de p1 de Adriano para Abiner

            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();


            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);
            Console.ReadKey();
        }
    }
}
