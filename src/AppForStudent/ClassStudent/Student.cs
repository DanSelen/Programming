using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class Student
{
    public string _fullName { get; set; }
    private  int _studentId;
    public string _numberGroup { get; set; }
    public Facultet Facultet { get; set; }
    public StudentFormOfStudy StudentFormOfStudy { get; set; }
    public int StudentId
    {
        get { return _studentId; }
        set { _studentId = value; }
    }
    public Student() { } // Обязательно наличие пустого конструктора для XML-сериализации
    public Student(string  fullName,  string numberGroup, Facultet facultet, StudentFormOfStudy studentFormOfStudy, int studentId)
    {
        _fullName = fullName;
        _numberGroup = numberGroup;
        Facultet = facultet;
        StudentFormOfStudy = studentFormOfStudy;
        if (studentId < 100000 || studentId > 999999)
        {
            throw new ArgumentException("Неверный формат номера зачетки. Номер должен состоять из 6 цифр.");
        }
        _studentId = studentId;

    }

    public override string ToString()
    {
        return $"{_fullName} - {_numberGroup} / {Facultet}";
    }

}

