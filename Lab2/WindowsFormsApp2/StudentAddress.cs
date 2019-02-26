using System;
using WindowsFormsApp2;
using System.Runtime.Serialization.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[DataContract]
public class Student
{
    private string first_name;
    private string second_name;
    private string otchestvo;
    private string birthday;
    private string specialization;
    private int course;
    private int age;
    private int groop;
    private string gender;
    private Adress address;

    [DataMember]
    [Required]
    public string FirstName { get => first_name; set => first_name = value; }
    [DataMember]
    [Required]
    public string SecondName { get => second_name; set => second_name = value; }
    [DataMember]
    [Required]
    public string Otchestvo { get => otchestvo; set => otchestvo = value; }
    [DataMember]
    public string Birthday { get => birthday; set => birthday = value; }
    [DataMember]
    [Required]
    public string Specialization { get => specialization; set => specialization = value; }
    [DataMember]
    public int Course { get => course; set => course = value; }
    [DataMember]
    public int Age { get => age; set => age = value; }
    [DataMember]
    public int Groop { get => groop; set => groop = value; }
    [DataMember]
    public string Gender { get => gender; set => gender = value; }
    [DataMember]
    [Required]
    public Adress Address { get => address; set => address = value; }

    public Student(Adress adr)
    {
        Address = adr;
    }
}
