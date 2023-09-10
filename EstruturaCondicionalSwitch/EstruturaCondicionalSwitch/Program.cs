using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicionalSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nome = "Adriano";
            //switch(nome)
            //{
            //    case "João": Console.WriteLine("Não é o cara"); break;
            //    case "Abner": Console.WriteLine("Não é o cara"); break;
            //    case "Davi": Console.WriteLine("Não é o cara"); break;
            //    case "Adriano": Console.WriteLine("Este é o cara!"); break;
            //    default: Console.WriteLine("Não foi encontrado nenhum nome"); break;
            //}

            //for (int i = 0; i < 5; i++) // incremental 
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 5; i > 0; i--) // decremental
            //{
            //    Console.WriteLine(i);
            //}


            //int valor = 0;
            //while(valor <= 5)
            //{

            //    Console.WriteLine(valor);
            //    valor++;
            //}


            int valor = 0;
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor <= 5);

            Console.ReadLine();
        }
    }
}
