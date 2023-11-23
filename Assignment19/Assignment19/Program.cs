using ShapeAreaLip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Operation 1.Rectangle 2.Square 3.Circle 4.Triangle");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Rectangle rectangle = new Rectangle();
                        Console.Write("Enter the length of the rectangle: ");
                        rectangle.Length = int.Parse(Console.ReadLine());
                        Console.Write("Enter the width of the rectangle: ");
                        rectangle.Width = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
                        break;
                    }
                case 2:
                    {
                        Square square = new Square();
                        Console.Write("Enter the side length of the square: ");
                        square.Side = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Square Area: {square.Area()}");
                        break;
                    }
                case 3:
                    {
                        Circle circle = new Circle();
                        Console.Write("Enter the radius of the circle: ");
                        circle.Radius = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Circle Area: {circle.Area()}");
                        break;

                    }

                case 4:
                    {
                        Triangle triangle = new Triangle();
                        Console.Write("Enter the base length of the triangle: ");
                        triangle.Base = int.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the triangle: ");
                        triangle.Height = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Triangle Area: {triangle.Area()}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operation Choice!!!");
                        break;
                    }


            }


            Console.ReadLine();

           Console.ReadKey();
        
       }
    }
}
