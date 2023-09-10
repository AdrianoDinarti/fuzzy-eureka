﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeradores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(2, "Mouse Game", 300.90, EProductType.Product);

            var ManutecaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
            
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.ReadLine();

        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        // Name = Propriedade
        // name = parametro 

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }



    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
