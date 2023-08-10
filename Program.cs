using Principal.Entities;
using Principal.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace Principal 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter the number of shapes: ");
            int shapesQty = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= shapesQty; i++) {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapesOption = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color shapesColor = Color.Parse<Color>(Console.ReadLine());

                if(shapesOption == 'r' || shapesOption == 'R') 
                {
                    Console.Write("Width: ");
                    double rectangleWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double rectangleHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(rectangleWidth, rectangleHeight, shapesColor));
                }

                else if(shapesOption == 'c' || shapesOption == 'C') {
                    Console.Write("Radius: ");
                    double circleRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle (circleRadius, shapesColor));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape item in shapes) {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}