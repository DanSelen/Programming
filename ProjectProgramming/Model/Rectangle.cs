using System;
using System.Drawing;

class Rectangle
{
    private double _length;
    private double _width;

    public Color Color { get; set; }

    public double Length
    {
        set
        {
            if (value > 0)
                throw new ArgumentException("Значение должно быть больше 0");
            else
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
            if (value > 0)
                throw new ArgumentException("Значение должно быть больше 0");
            else
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
        Color = Color.Gray;
    }
}