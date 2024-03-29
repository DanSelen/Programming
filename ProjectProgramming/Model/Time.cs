using ProjectProgramming.Model;
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
            Validator.AssertValueInRange(value, 0, 25);
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
            Validator.AssertValueInRange(value, 0, 61);
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
            Validator.AssertValueInRange(value, 0, 61);
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
    public Time()
    {
        Hours = 1;
        Minutes = 1;
        Seconds = 1;
    }
}