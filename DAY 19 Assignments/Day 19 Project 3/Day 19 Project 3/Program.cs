using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_19_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument XD = new XmlDocument();
            XD.Load("C:\\Day 19 Assignments\\MyData(TagBased).xml");

            foreach (XmlNode node in XD.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "ID")
                        Console.Write(childNode.InnerText + ",");
                    if (childNode.Name == "Name")
                        Console.Write(childNode.InnerText+ ",");
                    if (childNode.Name == "Age")
                        Console.Write(childNode.InnerText+ "\n");

                }
            }
            Console.ReadLine();
        }
    }
}
