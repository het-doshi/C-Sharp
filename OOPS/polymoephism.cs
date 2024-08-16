using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
/* 
 To perform method overriding in C#, you need to use virtual keyword with base 
 class method and override keyword with derived class method.
*/

/* 
 bssic keyword 
 You can use base keyword within instance method, constructor or instance property 
 accessor only. You can't use it inside the static method.

 We can use the base keyword to access the fields of the base class within derived 
 class. It is useful if base and derived classes have the same fields. If derived 
 class doesn't define same field, there is no need to use base keyword. Base class 
 field can be directly accessed by the derived class.
*/ 

/*
 polymorphism two types
 compile time can be achived by method | operator overloading 
 runtime can be achived by method overridingo
 */
public class Base1 
{
    String name;
    int age = 0;
    
    string activity = "no";

    public string color = "red";

    public Base1(){}
   public Base1(string n, int a)
   {
      name = n;
      age = a;
   }

   public Base1 (string n, string a) //constructor | member overloading 
   {
      name = n;
      activity = a;
   }

   public void Info()
   {
      Console.WriteLine($"name : {name} age: {age} activity: {activity}");
   }
   
   public virtual void Greet(string name)
   {
        Console.WriteLine("hello");
   }

}

public class Derive1:Base1
{
    public override void Greet(string name) // method overiding
    {
        Console.WriteLine($"!hello {name}");
   }

   string color = "white";

   public void ShowColor()
   {
     Console.WriteLine("Derive class color "+color);
     Console.WriteLine("Base class color "+base.color);
   }

}

public class Polymorpism
{
    

    public static void Main()
    {
        //constructor overloading
        Base1 b1 = new Base1("alex","coding");
        Base1 b2 = new Base1("john",20);
        b1.Info();
        b2.Info();
        b1.Greet("Alex");

        Derive1 d1 =new Derive1();
        d1.Greet("john"); // method overiding
        d1.ShowColor();
       

    }
}