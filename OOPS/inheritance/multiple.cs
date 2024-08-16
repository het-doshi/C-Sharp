using System.Collections.Specialized;

public class Person   // base1
{
  string name;
  int age;

  public void info(int age, string name)
  {
     this.age = age;
     this.name = name;
     Console.WriteLine("name: "+name+" age: "+age);
  }
}

public class Programmer : Person //base2 1 level inheritance
{
    string lang;

    public void pinfo(string l)
    {
        this.lang = l;
        Console.WriteLine("curently working in "+lang+" as language");
    }
}

public class Employee : Programmer // derived class multiple level inheritance
{
    int salary;
    string company;

    public void cinfo(int s,string c)
    {
        salary = s;
        company = c;
       Console.WriteLine("salary: "+salary+" company "+company);
    }

}

public class Multiple
{
    public static void Main()
    {
        Employee e1 = new Employee();
        e1.info(21,"alex");
        e1.cinfo(50000,"alex&co");
        e1.pinfo("c#");
    }
}