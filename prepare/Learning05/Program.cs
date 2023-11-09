using System;
using System.Reflection.Metadata;
//CSE210 Shape Area Program
//v0.1.0
//©2023 Joshua Martinez
//Instructions from https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html
class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        //Create shape objects and add them to the list
        Square _square = new Square("red", 4.89);
        Rectangle _rectangle = new Rectangle("purple", 16, 8); 
        Circle _circle = new Circle("blue", 3.5);
        _shapes.Add(_square); _shapes.Add(_rectangle); _shapes.Add(_circle);

        //Go through the shapes and display their colors and areas
        foreach (Shape polygon in _shapes){
            Console.WriteLine(polygon.GetColor());
            Console.WriteLine(polygon.GetArea());
        }
    }
}