using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_9_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Reading XML Files using C#
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument XD = new XmlDocument();
            XD.Load("C:\\Day 19 Assignments\\MyData(TagBased).xml");

            foreach (XmlNode node in XD.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;

                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
