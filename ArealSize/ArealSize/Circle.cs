﻿namespace ArealSize;

public class Circle
{
    private double _area = 0;
    private readonly double _radius = 0;
    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area()
    {
        _area = Math.PI*Math.Pow(_radius,2);
        return _area;
    }
}