using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("blue", 4);
        //Console.WriteLine($"The color of the square is {mySquare.GetColor()}.");
        //Console.WriteLine($"The area of the square is {mySquare.GetArea()}.");

        Rectangle myRectangle = new Rectangle("red", 9, 3);
        //Console.WriteLine($"The color of the rectangle is {myRectangle.GetColor()}.");
        //Console.WriteLine($"The area of the rectangle is {myRectangle.GetArea()}.");

        Circle myCircle = new Circle("green", 5);
        //Console.WriteLine($"The color of the circle is {myCircle.GetColor()}.");
        //Console.WriteLine($"The area of the circle is {myCircle.GetArea()}.");

        List<Shape> myShapes = new List<Shape>();
        myShapes.Add(mySquare);
        myShapes.Add(myRectangle);
        myShapes.Add(myCircle);

        foreach (Shape s in myShapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
            Console.WriteLine();
        }
    }
}