using System;

public class Student
{
    private int Student_Id;
    private String Student_Name;
    public void Student_Read()
    {
        Console.WriteLine("Enter Studentid");
        Student_Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Studentname");
        Student_Name = Console.ReadLine();
    }
    public void Student_display()
    {
        Console.WriteLine("Studentid={0}", Student_Id);
        Console.WriteLine("Studentname={0}", Student_Name);
    }
}
public class internals : Student
{
    protected int Marks_internal;
    public void internals_Read()
    {
        base.Student_Read();
        Console.WriteLine("Enter internalmarks of student");
        Marks_internal = int.Parse(Console.ReadLine());
    }
    public void internals_display()
    {
        base.Student_display();
        Console.WriteLine("internal marks={0}", Marks_internal);
    }
}
public class externals : internals
{
    private int Marks_external;
    private int Marks_Total;
    public void externals_Read()
    {
        internals_Read();
        Console.WriteLine("Enter external marks of student");
        Marks_external = int.Parse(Console.ReadLine());
    }
    public void externals_display()
    {
        internals_display();
        Console.WriteLine("external marks={0}", Marks_external);
    }
    public int externals_Calculate()
    {
        Marks_Total = Marks_internal + Marks_external;
        return Marks_Total;
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        externals e = new externals();
        e.externals_Read();
        e.externals_display();
        Console.WriteLine("Total Marks got={0}", e.externals_Calculate());
    }
}
