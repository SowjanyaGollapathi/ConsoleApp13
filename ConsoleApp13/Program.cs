using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Chinnu", "Bhannu", "Honey", "Candy", "Ruben", "Riyansh", "Joel", "Josuph" };
            LINQtoXmlAddNode();         
        }

        private static void LINQtoXmlAddNode()
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
