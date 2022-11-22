using System;

class Student
{
    string name;
    int rollNumber;

    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Gisna";
        s1.rollNumber = 1;

        Student s2 = new Student();
        s2.name = "Anjana";
        s2.rollNumber = 2;

        s1.DisplayDetails();
        s2.DisplayDetails();
    }
}

