using System;

class Program
{
    static void Main()
    {
        Student[] students = null;
        CreateArray(ref students);
        AcceptInfo(students);
        PrintInfo(students);
        Student[] reversedStudents = ReverseArray(students);
        PrintInfo(reversedStudents);
    }

    static void CreateArray(ref Student[] students)
    {
        Console.WriteLine("Enter the number of students:");
        int size = Convert.ToInt32(Console.ReadLine());
        students = new Student[size];
    }

    static void AcceptInfo(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            students[i].AcceptDetails();
        }
    }

    static void PrintInfo(Student[] students)
    {
        foreach (var student in students)
        {
            student.PrintDetails();
        }
    }

    static Student[] ReverseArray(Student[] students)
    {
        Student[] reversedStudents = new Student[students.Length];
        for (int i = 0, j = students.Length - 1; i < students.Length; i++, j--)
        {
            reversedStudents[j] = students[i];
        }
        return reversedStudents;
    }
}