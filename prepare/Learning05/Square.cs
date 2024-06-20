using System.Formats.Asn1;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side)
        :base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double _area = _side * _side;
        return _area;
    }
}