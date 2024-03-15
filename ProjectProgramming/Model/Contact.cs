using System;

class Contact
{
    private string _name;
    private string _email;
    private string _number;

    public string Name
    {
        set
        {
            Name = value;
        }
        get
        {
            return _name;
        }
    }
    public string Number /// _number - это номер телефона без знака, начиная с 7
    {
        set
        {
            if (_number.Length != 11)
                throw new ArgumentException("Номер телефона должен содержать 11 цифр");
            else
                _number = value;
        }
        get
        {
            return _number;
        }
    }

    public string Email
    {
        set
        {
            _email = value;
        }
        get
        {
            return _email;
        }
    }
    public Contact()
    {
        Name = "";
        Number = "";
        Email = "";
    }


    public Contact(string name, string email, string number)
    {
        Name = name;
        Number = number;
        Email = email;
    }
}