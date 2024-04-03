using ProjectProgramming.Model;
using System;
using System.Drawing;

class Rectangle
{
    private double _length;
    private double _width;
    private string _color;
    static int _allRectanglesCount;
    readonly int _id = 0;

    public int Id
    {
        get { return _id; }
    }
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public Point2D Center => new Point2D(Length / 2,Width / 2);
    public Point2D Coordinates { get; set; }

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
            Validator.AssertOnPositiveValue(value,nameof(Length));
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
            Validator.AssertOnPositiveValue(value,nameof(Width));
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
        Coordinates = new Point2D(1, 1);
        _id = ++_allRectanglesCount;

    }
    public Rectangle (double length, double width, Point2D coordinates, string color)
    {
        Length = length;
        Width = width;
        Color = color;
        Coordinates = coordinates;
        _id = ++_allRectanglesCount;

    }
}