class Movie
{
    private string _name;
    private int _duration;
    private int _year
    {
        set
        {
            if (value > 1900)
                _year = value;
        }
        get
        {
            return _year;
        }
    }
    private string _genre;
    private int _rating
    {
        set
        {
            if (value >= 0 & value <=10)
                _rating = value;
        }
        get
        {
            return _rating;
        }
    }
}