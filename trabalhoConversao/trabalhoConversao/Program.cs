using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoConversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 100;
            float real = 25.8f;

            //real = numero; // conversão explicita
            //numero = (int)real; // conversão implícita
            numero = Convert.ToInt32(real);

            Console.WriteLine(numero);
            Console.ReadLine();
        }
    }
}
