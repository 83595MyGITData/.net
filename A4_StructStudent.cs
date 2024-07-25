using System;

struct Student
{
    private string name;
    private bool gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    public Student(string name, bool gender, int age, int std, char div, double marks)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.std = std;
        this.div = div;
        this.marks = marks;
    }

    public string Name { get => name; set => name = value; }
    public bool Gender { get => gender; set => gender = value; }
    public int Age { get => age; set => age = value; }
    public int Std { get => std; set => std = value; }
    public char Div { get => div; set => div = value; }
    public double Marks { get => marks; set => marks = value; }

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Name:");
        Name = Console.ReadLine();

        Console.WriteLine("Enter Gender (true for male, false for female):");
        Gender = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Std:");
        Std = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Div:");
        Div = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter Marks:");
        Marks = Convert.ToDouble(Console.ReadLine());
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Std: {Std}");
        Console.WriteLine($"Div: {Div}");
        Console.WriteLine($"Marks: {Marks}");
    }
}