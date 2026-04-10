using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 4, 5);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 6);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            // Polymorphism in action: 
            // The computer knows which GetArea() to call!
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:0.00}.");
        }
    }
}