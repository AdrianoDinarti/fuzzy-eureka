using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine("1 - abrir arquivo ");
            Console.WriteLine("2 - criar novo arquivo ");
            Console.WriteLine("0 - sair ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (Esc para sair)");
            Console.WriteLine("-----------------------------------------");
            string text = "";
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
