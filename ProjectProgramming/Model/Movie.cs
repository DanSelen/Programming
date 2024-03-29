using ProjectProgramming.Model;
using System;
using System.Xml.Linq;

class Movie
{
    private string _name;
    private int _duration;
    private int _year;
    private int _rating;
    private string _genre;
    public int Year
    {
        set
        {
            Validator.AssertOnPositiveValue(value);
            _year = value;
        }
        get
        {
            return _year;
        }
    }
    public string Genre
    {
        set
        {
            _genre = value;
        }
        get
        {
            return _genre;
        }
    }
    public int Rating
    {
        set
        {
            Validator.AssertValueInRange(value,0,11);
            _rating = value;
        }
        get
        {
            return _rating;
        }
    }
    public int Duration
    {
        set
        {
            _duration = value;
        }
        get
        {
            return _duration;
        }
    }
    public string Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }
    public Movie (string name, int duration, int year, int rating, string genre)
    {
        Name = name;
        Duration = duration;
        Year = year;
        Rating = rating;
        Genre = genre;
    }

    public Movie ()
    {
        Name = "";
        Duration = 0;
        Year = 0;
        Rating = 0;
        Genre = "";
    }
}