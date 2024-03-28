using System;

class Contact
{
    private string _name;
    private string _surname;
    private string _email;
    private string _number;

    public string Name
    {
        set
        {
            AssertStringContainsOnlyLetters(value);
            _name = value;
        }
        get
        {
            return _name;
        }
    }
    public string Surname
    {
        set
        {
            AssertStringContainsOnlyLetters(value);
            _surname = value;
        }
        get
        {
            return _surname;
        }
    }
    private void AssertStringContainsOnlyLetters(string str) // ������� ������������ ��������, ��� ������ �������� ������� ������ ���������� ��������
    {
        foreach (char c in str)
        {
            if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
            {
                throw new ArgumentException("String should contain only English alphabet characters.");
            }
        }
    }
    public string Number // _number - ��� ����� �������� ��� �����, ������� � 7
    {
        set
        {
            if (_number.Length != 11)
                throw new ArgumentException("����� �������� ������ ��������� 11 ����");
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
        Surname = "";
        Number = "";
        Email = "";
    }


    public Contact(string name, string surname, string email, string number)
    {
        Name = name;
        Surname = surname;
        Number = number;
        Email = email;
    }
}