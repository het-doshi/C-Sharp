using System;  
public class Oops 
{
    string name;
    int age;

// Default Constructor
   public Oops() 
   {
     Console.WriteLine("Default Constructor invoked");
   }

   // parameterized Constructor
   public Oops(string n, int a)
   {
      name = n;
      age = a;
   }

   public void ShowDetails()
   {
      Console.WriteLine("Name: "+name+" Age: "+age);
   }


   /* Destructor : In C#, a destructor is a special method used to clean up resources
    before an object is destroyed. It is called automatically by the garbage
    collector when an object is no longer in use |purpose: cleanup resource(database)
   */ 
   ~Oops()
   {
      Console.WriteLine("destructor is invoked");
   }

   // this keyword
   float salary;
   string designation;

   //used to distinguish between when class field and parameters name are same
   public void ShowInfo(float salary, string designation)
   {
     this.designation = designation;
     this.salary = salary;
     Console.WriteLine("designation: "+designation+" salary: "+salary);
   }

   //this keyword to pass current obj
   public static void ShowAllDetails(Oops o1)
   {
      Console.WriteLine("Name: "+o1.name);
      Console.WriteLine("Age: "+o1.age);
      Console.WriteLine("designation: "+o1.designation);
      Console.WriteLine("salary: "+o1.salary);
   }

   

    public static void Main(string[] args)
    {        
        //Object is a runtime entity, it is created at runtime.
        Oops o1 = new Oops();
        o1.name = "object1";
        o1.age = 20;
        Console.WriteLine(o1.name);
        Console.WriteLine(o1.age);
        Console.WriteLine();

         //constructor | why to use it 
        //  It is used to initialize the data members of new object generally
 
       //creating object using Parameterized Constructor
       Oops o2 = new Oops("alex",25);
       o2.ShowDetails();

       //this keyword field example
       o1.ShowInfo(1250,"intern");
       Console.WriteLine();

       //this keyword for passing current object
       Oops o3 = new Oops("john",21);
       o3.ShowInfo(1450,"intern");
       ShowAllDetails(o3);
    }
}