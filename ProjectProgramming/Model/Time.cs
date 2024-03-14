class Time
{
    private int _hours
    {
        set
        {
            if (value >= 0 value<24)
                _hours = value;
        }
        get
        {
            return _hours;
        }
    }
    private int _minutes;
    {
        set
        {
            if (value >= 0 & value < 60)
                _minutes = value;
        }
        get
        {
            return _minutes;
        }
    }
    private int _seconds
    {
        set
        {
            if (value >= 0 & value < 60)
                _seconds = value;
        }
        get
        {
            return _seconds;
        }
    }
}