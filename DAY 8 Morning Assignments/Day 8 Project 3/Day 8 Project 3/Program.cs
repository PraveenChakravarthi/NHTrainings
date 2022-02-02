using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Project_3
{
    // Author : Praveen Chakravarthi
    // Purpose : Product Class (if Condition)

    class Product
    {
        public int Id;
        public string Name;
        public string Brand;
        public int Price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Prod = new List<Product>
            {
                new Product() { Id = 11, Name = "HeadPhones", Brand = "Boat", Price = 400 },
                new Product() { Id = 12, Name = "PowerBank", Brand = "Lenovo", Price = 650 },
                new Product() { Id = 13, Name = "Speaker", Brand = "JBL", Price = 800 },
                new Product() { Id = 14, Name = "Adapter", Brand = "pTron", Price = 450 }
            };

            // using for Loop
            Console.WriteLine("**************");
            Console.WriteLine("using for Loop");
            Console.WriteLine("**************");

            for (int i= 0; i < Prod.Count; i++)
            {
                if (Prod[i].Price>500)
                    Console.WriteLine(Prod[i].Brand + "-" + Prod[i].Name);
            }

            // using foreach Loop
            Console.WriteLine("******************");
            Console.WriteLine("using foreach Loop");
            Console.WriteLine("******************");

            foreach (var p in Prod)
            {
                if (p.Price>500)
                    Console.WriteLine(p.Brand + "-" + p.Name);
            }

            // using Lambda Expression
            Console.WriteLine("***********************");
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine("***********************");

            Prod.Where(p => p.Price > 500).ToList().ForEach(p => Console.WriteLine(p.Brand + "-" + p.Name));

            // using Linq Query
            Console.WriteLine("****************");
            Console.WriteLine("using Linq Query");
            Console.WriteLine("****************");

            var Result = from p in Prod
                         where p.Price > 500
                         select p;
            Result.ToList().ForEach(p => Console.WriteLine(p.Brand + "-" + p.Name));

            Console.ReadLine();
        }
    }
}
