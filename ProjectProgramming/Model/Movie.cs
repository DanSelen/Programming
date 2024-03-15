using System;

class Movie
{
    private string _name;
    private int _duration;
    private int _year;
    private int _rating;
    private string _genre;
    private int Year
    {
        set
        {
            if (value < 1900)
                throw new ArgumentException("Фильм не может быть старее 1900 года");
        }
        get
        {
            return Year;
        }
    }
    private string Genre
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
    private int Rating
    {
        set
        {
            if (value < 0 & value > 10)
                throw new ArgumentException("Рейтинг должен быть в диапазоне от 0 до 10");
        }
        get
        {
            return _rating;
        }
    }
    private int Duration
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
    private string Name
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
}