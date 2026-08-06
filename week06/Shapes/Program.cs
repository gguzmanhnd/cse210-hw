using System;
using System.Collections.Generic;

namespace Shapes;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shape instances to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 6));
        shapes.Add(new Circle("Green", 3));

  
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}