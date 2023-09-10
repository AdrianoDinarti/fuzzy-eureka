using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imforme o peso em Kg: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Imforme a altura em Metros: ");
            float altura = float.Parse(Console.ReadLine());

            float valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Abaixo do peso.");
            }
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Normal.");
            }
            else if (valorIMC >= 25 && valorIMC <= 29)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Acima do peso.");
            }
            else if (valorIMC >= 30 && valorIMC <= 34)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Obeso.");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> obesidade morbida");
            }

            Console.ReadKey();

            

        }
    }
}
