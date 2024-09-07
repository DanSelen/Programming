using ProjectProgramming.Model;
using System;

class Discipline
{
    string _disciplineName;
    int _grade;
    int _semester;

    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0)
                throw new ArgumentException("Длинна строки не должна быть 0");
            else _disciplineName = value;
        }
    }
    public int Grade
    {
        get { return _grade; }
        set
        {
            Validator.AssertValueInRange(value, 0, 6,nameof(Grade));
            _grade = value;
        }
    }
    public int Semester
    {
        get { return _semester; }
        set
        {
            Validator.AssertValueInRange(value, 0, 9, nameof(Semester));
            _semester = value;
        }
    }

    public Discipline(string disciplineName, int grade, int semester)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
    }

    public Discipline()
    {
        DisciplineName = "";
        Grade = 2;
        Semester = 1;
    }
}