using ProjectProgramming.Model;
using System;
using System.Drawing;

class Rectangle
{
    private double _length;
    private double _width;
    private string _color;
    
    public string Color
    {
        set
        {
            _color = value;
        }
        get
        {
            return _color;
        }
    }
    public double Length
    {
        set
        {
            Validator.AssertOnPositiveValue(value);
            _length = value;
        }
        get 
        { 
            return _length; 
        }
    }
    public double Width
    {
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
        get
        {
            return _width;
        }
    }
    public Rectangle ()
    {
        Length = 1;
        Width = 1;
        Color = "";

    }
    public Rectangle (double length, double width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }
}