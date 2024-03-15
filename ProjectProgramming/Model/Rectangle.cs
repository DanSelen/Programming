class Rectangle
{
    private double _length
    {
        set
        {
            if (value > 0)
                _length = value;
        }
        get 
        { 
            return _length; 
        }
    }
    private double _width
    {
        set
        {
            if (value > 0)
                _width = value;
        }
        get
        {
            return _width;
        }
    }
    private double _color
    {
        set
        {
            if (value > 0)
                _color = value;
        }
        get
        {
            return _color;
        }
    }
}