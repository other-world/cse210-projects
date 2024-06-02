using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

public class Circle : Shape

{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double area = Math.Pow(_radius, 2) * Math.PI;
        return area;
    }
}