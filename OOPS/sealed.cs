/* 
 sealed class cannot be override
 sealed method also cannot be override
*/

//sealed method

public class Person
{
    string name;
    int age;
    
   
   public virtual void GenralInfo(string n, int a)
   {
       name = n;
       age = a;
       Console.WriteLine("person class genralinfo");
       Console.WriteLine($"name is {name} age {age}");
   }


    public virtual void SalaryInfo(int salary)
    {
         Console.WriteLine("person class salaryinfo");
        Console.WriteLine("salary is :"+salary);
    }

}

public class Manager : Person
{
    
    int bonous = 5000;

    // now this below method is sealed in manager so it cannot be override 
    sealed override public void SalaryInfo(int salary) 
    {
        int total = bonous + salary;
        Console.WriteLine("manager class salaryinfo");
       Console.WriteLine("salary is "+total);
    }
}

public class Employee : Manager
{
    public override void GenralInfo(string n, int a)
    {
        Console.WriteLine("employee class genralinfo");
        Console.WriteLine($"name is {n} age {a}");
    }

    // Cannot override SalaryInfo method because it's sealed in Manager
}

// the sealed class cannot be derived 
// if we try to derive this class it will throw an error 
sealed public class Sealed1
{
   public static void Main()
   {
    
     // person class
     Console.WriteLine("person class");
     Person p1 = new Person();
     p1.GenralInfo("alex",20);
     p1.SalaryInfo(2500);
     Console.WriteLine();
    

     // Manager class
     Console.WriteLine("manager class");
     Manager m1 = new Manager();
     m1.GenralInfo("john",20);
     m1.SalaryInfo(5000);
     Console.WriteLine();
     
     // Employee class
     Console.WriteLine("employee class");
     Employee e1 = new Employee();
     e1.GenralInfo("employee1",20); 

     /* The Employee class does not have access to override SalaryInfo because 
     it's sealed in Manager */

      Console.WriteLine(); 
   }
}