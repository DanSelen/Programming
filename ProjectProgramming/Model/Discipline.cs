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
            if (value<2 & value > 5)
                throw new ArgumentException("оценка должна быть от 2 до 5");
            else _grade = value;
        }
    }
    public int Semester
    {
        get { return _semester; }
        set
        {
            if (value < 1 & value > 8)
                throw new ArgumentException("Значение семестра должно быть от 1 до 8");
            else _semester = value;
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