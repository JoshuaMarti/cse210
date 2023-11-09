using System.Reflection.Metadata.Ecma335;

public class Square : Shape {
    private double _side;
    public Square(string color, double side){
        SetColor(color);
        _side = side;
    }
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}