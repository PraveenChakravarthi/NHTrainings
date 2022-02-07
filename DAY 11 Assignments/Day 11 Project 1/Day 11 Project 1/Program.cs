using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Interface Class

    interface Ishape
    {
        /// <summary>
        /// This method finds Area of the given Shape
        /// </summary>
        int Area();

        /// <summary>
        /// This Method finds Perimeter of the given Shape
        /// </summary>
        int Perimeter();
    }
    class Square : Ishape
    {
        public int side;

        public void ReadSide()
        {
            Console.WriteLine("Enter side: ");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int Perimeter()
        {
            return 4 * side;
        }

        public int Area()
        {
            return side * side;
        }
    }

    class Circle : Ishape
    {
        public int radius;

        public void ReadRadius()
        {
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int Perimeter()
        {
            return (2 * 22 * radius) / 7;
        }

        public int Area()
        {
            return (22 * radius * radius)/7;
        }
    }

    class Rectangle : Ishape
    {
        public int length;
        public int breadth;

        public void ReadLB()
        {
            Console.WriteLine("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            breadth = Convert.ToInt32(Console.ReadLine());
        }
        public int Perimeter()
        {
            return 2 * (length+breadth);
        }

        public int Area()
        {
            return length * breadth;
        }
    }

    class Triangle : Ishape
    {
        public int a;
        public int b;
        public int c;
        public int s;

        public void ReadABC()
        {
         
            Console.WriteLine("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = Convert.ToInt32(Console.ReadLine());
            s=(a+b+c)/2;
        }
        public int Perimeter()
        {
            return a+b+c;
        }

        public int Area()
        {
            return (int)(Math.Sqrt(s*(s - a)*(s - b)*(s - c))); // Heron's Formula
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.ReadSide();
            Console.WriteLine($"Area of Square= {sq.Area()}");
            Console.WriteLine($"Perimeter of Square = {sq.Perimeter()}");

            Circle cr = new Circle();
            cr.ReadRadius();
            Console.WriteLine($"Area of Circle= {cr.Area()}");
            Console.WriteLine($"Perimeter of Circle = {cr.Perimeter()}");

            Rectangle rt = new Rectangle();
            rt.ReadLB();
            Console.WriteLine($"Area of Rectangle= {rt.Area()}");
            Console.WriteLine($"Perimeter of Rectangle= {rt.Perimeter()}");

            Triangle tr = new Triangle();
            tr.ReadABC();
            Console.WriteLine($"Area of Triangle= {tr.Area()}");
            Console.WriteLine($"Perimeter of Triangle= {tr.Perimeter()}");

            Console.ReadLine();

        }
    }
}
