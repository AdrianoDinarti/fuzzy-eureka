using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(2, "Mouse Game", 300.90);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.ReadLine();
        }
    }

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        // Name = Propriedade
        // name = parametro 

        public int Id;
        public string Name; 
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}
