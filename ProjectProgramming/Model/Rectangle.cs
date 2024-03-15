using System;

class Rectangle
{
    private double _length;
    private double _width;
    private double _color;

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
    public double Color
    {
        set
        {
            if (value > 0)
                throw new ArgumentException("Значение должно быть больше 0");
            else 
                _color = value;
        }
        get
        {
            return _color;
        }
    }
}