using ProjectProgramming.Model;

class Song
{
    private string _name;
    private string _artist;
    private string _album;
    private int _during;    ///продолжительность в секундах

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

    public string Artist
    {
        set
        {
            _artist = value;
        }
        get
        {
            return _artist;
        }
    }

    public string Album
    {
        set
        {
            _album = value;
        }
        get
        {
            return _album;
        }
    }

    public int During
    {
        set
        {
            Validator.AssertOnPositiveValue(value);
            _during = value;
        }
        get
        {
            return _during;
        }
    }

    public Song(string name, string artist, string album, int during)
    {
        Name = name;
        Artist = artist;
        Album = album;
        During = during;
    }
    public Song()
    {
        Name = "";
        Artist = "";
        Album = "";
        During = 1;
    }
}