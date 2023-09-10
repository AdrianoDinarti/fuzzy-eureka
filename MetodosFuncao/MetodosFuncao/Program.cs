using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MetodosFuncao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MeuMetodo();
            
            
            string nome = RetornaNome("Adriano", "Dinarti");
            Console.WriteLine(nome);
            Console.ReadLine();
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
            Console.ReadLine();
        }

        static string RetornaNome(string nome, string sobrenome, int idade = 24)
        {
            return nome + " " + sobrenome + " tem "  +  idade.ToString();
        }
    }
}
