using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_4
{
    // Author : Praveen Chakravarthi
    // Purpose : Reading XML using C# and printing names of particular ID
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            XmlDocument XD = new XmlDocument();
            XD.Load("C:\\Day 19 Assignments\\MyData(TagBased).xml");
            foreach (XmlNode node in XD.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    bool id = childnode.Name == "ID";
                    bool isIndex = (id == true ? Convert.ToInt32(childnode.InnerText): 0) == n;
                    if (id && isIndex)
                    {
                        Console.WriteLine(childnode.NextSibling.InnerText);
                    }
                }
            }
                Console.ReadLine();
        }
    }
}
