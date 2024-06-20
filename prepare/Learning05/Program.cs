using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1= new Square("blue", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("red", 6, 7);
        shapes.Add(s2);
        
        Circle s3 = new Circle("green", 8);
        shapes.Add(s3);
        

        foreach (Shape shape in shapes)
        {
            string _color = shape.GetColor();
            double _area = shape.GetArea();

            Console.WriteLine($"The {_color} shape has an area of {_area}");
            Console.WriteLine();
        }
    }
}