using System;

class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;
    public int Hours
    {
        set
        {
            if (value < 0 & value >= 24)
               throw new ArgumentException("Значение должно быть от 0 до 24");
            else 
                _hours = value;
        }
        get
        {
            return _hours;
        }
    }
    public int Minutes
    {
        set
        {
            if (value < 0 & value > 60)
                throw new ArgumentException("Значение должно быть от 0 до 60");
            else
                _minutes = value;
        }
        get
        {
            return _minutes;
        }
    }
    public int Seconds
    {
        set
        {
            if (value < 0 & value >= 60)
                throw new ArgumentException("Значение должно быть от 0 до 60");
            else
                _seconds = value;
        }
        get
        {
            return _seconds;
        }
    }

    public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
}