using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(5, 7);
            R1.CalculateArea();
            R1.CalculatePrimeter();
            
            Console.WriteLine("****************************");

            Square S1 = new Square(8);
            S1.CalculateArea();
            S1.CalculatePrimeter();
           
            Console.WriteLine("****************************");

            Circle C1 = new Circle(5);
            C1.CalculateArea();
            C1.CalculatePrimeter();
            

            Console.ReadKey();
        }
    }
}
