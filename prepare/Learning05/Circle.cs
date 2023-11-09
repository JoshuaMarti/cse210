using System.Reflection.Metadata;

public class Circle : Shape {
    private double _radius;
    public Circle(string color, double radius){
        SetColor(color);
        _radius = radius;
    }
    public override double GetArea()
    {
        return(Math.PI * Math.Pow(_radius, 2));
    }
}