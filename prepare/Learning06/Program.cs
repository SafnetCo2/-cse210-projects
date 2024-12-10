using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to hold different shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("blue", 4));
        shapes.Add(new Rectangle("green", 5, 3));
        shapes.Add(new Circle("red", 2.5));

        // Iterate through the list and display color and area
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}
