using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string jsonInput = @"{ ""Shape"": ""Circle"", ""Radius"": 5 }"; // Example JSON input

        // Deserialize JSON to extract shape data
        var shapeData = JsonSerializer.Deserialize<ShapeData>(jsonInput);

        Shape shape = null;

        if (shapeData.Shape == "Circle")
        {
            shape = new Circle(shapeData.Radius);
        }

        if (shape != null)
        {
            Console.WriteLine($"Area of the {shapeData.Shape}: {shape.CalculateArea()}");
        }
        else
        {
            Console.WriteLine("Invalid shape specified.");
        }
    }
}
