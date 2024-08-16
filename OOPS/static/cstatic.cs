using System.Reflection;

public class Employee{

 /*
  Static Keyword : In C#, static is a keyword or modifier that belongs to the type 
  not instance. So instance is not required to access the static members. 
  In C#, static can be field, method, constructor, class, properties, operator 
  and event.  

 -> there is only one copy of static field created in the memory. 
  It is shared to all the objects.


 */

  string name;
   static string companyName; // static field
  
   int salary;

   Employee(string n, int s)
   {
     name = n;
     salary = s;
   }
   
   public void Info()
   {
      Console.WriteLine($"name: {name} salary: {salary} Company: {companyName}");
   }

   // static method: It performs operations that are independent of any particular instance of the class.
   public static void Greet(string name)
   {
     Console.WriteLine("!hello "+name);
   }
   
   /* static constructor
       use to intialize static fields | use if want to perform task once only 
       like db connection etc.. 
    */
   static Employee()
   {
     companyName = "info";
   }

public static void Main()
{
    Employee e1 = new Employee("alex",50000);
    e1.Info(); // info
    Employee e2 = new Employee("john",40000);
    e2.Info();

    Console.WriteLine();

    Employee.companyName = "InfoTech";

    e1.Info(); // infotech | static shares common copy to all obj
    e2.Info();

    Greet("alex"); // calling static method 

    int min = MathFun.Min(20,5); // calling method from static class
    Console.WriteLine(min);
 
}   

}