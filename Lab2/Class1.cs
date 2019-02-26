using System;

public class Adress
{
    private string city;
    private string street;
    private int house;
    private int flat;

    public string City { get => city; set => city = value; }
    public string Street { get => street; set => street = value; }
    public int House { get => house; set => house = value; }
    public int Flat { get => flat; set => flat = value; }
}

public class Student
{
    private string first_name;
    private string second_name;
    private string otchestvo;
    private string birthday;
    private string specialization;
    private int course;
    private double average_mark;
    private string gender;
    private Address address;

    public string FirstName { get => name; set => name = value; }
    public string SecondName { get => second_name; set => second_name = value; }
    public string Otchestvo { get => otchestvo; set => otchestvo = value; }
    public string Birthday { get => date_of_birth; set => date_of_birth = value; }
    public string Specialization { get => specialization; set => specialization = value; }
    public int Course { get => kurs; set => kurs = value; }
    public double AverageMark { get => average_mark; set => average_mark = value; }
    public string Gender { get => gender; set => gender = value; }
    public Address Address_ { get => address; set => address = value; }

    public Student()
    { }
    public Student(Address adr)
    {
        Address_ = adr;
    }
}
