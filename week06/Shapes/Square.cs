namespace Shapes;
public class Square : Shape
{
    public double _Side;

    public Square(String color, double side) : base(color)
    {
        _Side = side;
    }

    public override double GetArea()
    {
        return _Side * _Side;
    }
}