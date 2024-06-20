public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
        :base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double _pi = 3.14;
        double _area = _pi * (_radius * _radius);
        return _area;
    }
}