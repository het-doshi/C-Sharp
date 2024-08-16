using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Xml.Schema;

public class Methods
{

  // simple method
  public static void Add(int a, int b)
  {
    Console.WriteLine(a + b);
  }


  // method overloading 
  // name are same diffrence in parameters
  public static int Area(int side)
  {
    Console.Write("The area of square is ");
    int area = side * side;
    Console.Write(area);
    Console.WriteLine();
    return area;
  }

  public static int Area(int length, int breath, int hieght)
  {
    Console.Write("The area of rectangle is ");
    int area = length * breath * hieght;
    Console.Write(area);
    Console.WriteLine();
    return area;
  }


  //method parameters and Arguments

  // multiple Parameters
  // Area(int length, int breath, int hieght)

  //Default parameters
  static void MyCountry(string country = "Indian")
  {
    Console.WriteLine("my country is " + country);
  }

  // return values 
  // so when declare any type of function it will return some value
  public static int Sub(int a, int b)
  {
    return a - b;
  }

  //named parameters
  public static void EmployeInfo(int id, String name, int salary)
  {
    Console.WriteLine("employe id is " + id + " employe name is " + name + " salary " + salary);
  }

  //call by value
  public static void CallByValue(int value)
  {
    value = value + value;
    Console.WriteLine("the value of var value inside function " + value);
  }

  //call by refrence 
  // here we have to use ref keyword for refrence of var
  public static void callByRefrence(ref int var)
  {
    var = var + var;
    Console.WriteLine("the value of var value inside function " + var);
  }

  // out keyword
  // here we have to use out keyword for out var
  public static void OutFunc(out int a, int b, out int c)
  {
    int sum = 10;
    a = b + sum;
    c = b + sum;
    b = 0;

  }

  //params : it used when we dont know how many no of arguments to be passed
  public static void PrintNames(params string[] names)
  {
    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine(names[i]);
    }
  }
  
  public static void Main(string[] args)
  {

    Add(1, 2);

    // method overloading
    Area(5);
    Area(2, 5, 3);

    // parameters and arguments

    // Default arguments
    MyCountry(); // now if i dont pass any value it will take default value
    MyCountry("usa"); // now this will take this passed value 


    // return values 
    int ans = Sub(10, 3);
    Console.WriteLine("return value is " + ans);

    //named parameters
    // here we have pass the parameters along with name in any order we can pass
    EmployeInfo(name: "alex", salary: 1250, id: 20);
    Console.WriteLine();

    //call by value : it will not change the orignal value of var
    Console.WriteLine("call by value");
    int value = 20;
    Console.WriteLine("before calling callby " + value);
    CallByValue(value);
    Console.WriteLine("after calling callby " + value);
    Console.WriteLine();

    //call by refrence : this change the value of orignal variable
    Console.WriteLine("call by Refrence");
    int var = 50;
    Console.WriteLine("before calling callbyRefrence " + var);
    callByRefrence(ref var); // ref keyword for passing refrence variable
    Console.WriteLine("after calling callbyRefrence " + var);
    Console.WriteLine();

    //out keyword
    /* The out keyword is useful when you need a method to return multiple values
    or when you need to ensure that an argument is initialized within the method.*/
    // use out keyword for passing out variable
    int a = 0, b = 10, c = 0;
    OutFunc(out a, b, out c);
    Console.WriteLine("value of a " + a);
    Console.WriteLine("value of b " + b);
    Console.WriteLine("value of c " + c);
    Console.WriteLine();

    //passing n no of argumensts using params
    Console.WriteLine("using params keyword");
    PrintNames("alex", "john", "doe", "alexa");
  }
}