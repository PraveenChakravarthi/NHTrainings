using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Day_9_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Reading XML using C# and Printing only Names
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument XD = new XmlDocument();
            XD.Load("C:\\Day 19 Assignments\\MyData(TagBased).xml");

            foreach (XmlNode node in XD.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                    if (childNode.Name == "Name")
                        Console.WriteLine(childNode.InnerText);
            }
            Console.ReadLine();

        }
    }
}
