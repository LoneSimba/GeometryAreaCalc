using System;
using System.Runtime.CompilerServices;
using GeometryAreaCalc;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adding new Cirlce.");
            Circle cirlce = new Circle(2.0);
            Console.WriteLine("Cirlce's radius is 2.0! Calculating it's area.");
            cirlce.GetArea();
            Console.WriteLine("Circle's area is " + cirlce.Area);
            Console.WriteLine("Adding new Triangle.");
            double[] i = { 2, 1, 1 };
            Triangle tri1 = new Triangle(i);
            Console.WriteLine("Triangle's sides are 2, 1 and 1! Calculating it's area.");
            tri1.GetArea("sides");
            Console.WriteLine("Triangle's area is " + tri1.Area);
            Console.WriteLine("Adding new Triangle.");
            double[] о = { 3.5, 3, 1 };
            Triangle tri3 = new Triangle(о);
            Console.WriteLine("Triangle's sides are 3.5, 3 and 1! Calculating it's area.");
            tri3.GetArea("sides");
            Console.WriteLine("Triangle's area is " + tri3.Area);
            Console.WriteLine("Adding new Triangle.");
            double[] k = { 2, 3, 1 };
            Triangle tri2 = new Triangle(k);
            Console.WriteLine("Triangle's sides are 3, 2 and 1! Checking wheter it right-angled.");
            if(tri2.IsRightAngled())
            {
                Console.WriteLine("Sure it is!");
            } 
            else
            {
                Console.WriteLine("I guess it's not.");
            }

            Console.WriteLine("Adding new Triangle.");
            double[] t = { 2, 2.236, 1 };
            Triangle tri4 = new Triangle(t);
            Console.WriteLine("Triangle's sides are 2.24, 2 and 1! Checking wheter it right-angled.");
            if (tri4.IsRightAngled())
            {
                Console.WriteLine("Sure it is!");
            }
            else
            {
                Console.WriteLine("I guess it's not.");
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
