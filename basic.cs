using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

public class Basic{

public static void Main(string[] args)
{

Console.Write("hello");// this will not add new line after printing 
Console.WriteLine("Hello, World!"); // this will add new line after printing 
Console.Write("see diference");
Console.WriteLine();

//type casting 
// Implicit casting 
// is done automatically when passing a smaller size type to a larger size type:
int a = 10;
double b = a; //type casting 
Console.WriteLine("implicit type casting");
Console.WriteLine(a);
Console.WriteLine(b);

//Explicit casting
// must be done manually by placing the type in parentheses in front of the value:
double ad = 99.99;
int bd = (int) ad;
/*
   or we can use Convert()
   When you use Convert.ToInt32 to convert a double to an int, 
   it rounds the double value to the nearest integer, 
   which is why you are seeing 100 instead of 99
 */

int cbd = Convert.ToInt32(ad);
Console.WriteLine("Explicit type casting");
Console.WriteLine(ad);
Console.WriteLine(bd);
Console.WriteLine(cbd);
Console.WriteLine();

//user input using console.readline() it will always return input value as string
Console.WriteLine("enter your name");
string name = Console.ReadLine() ?? "Default Name";
Console.WriteLine("enter your age");
int age = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("your name is "+name);
Console.WriteLine("your age is "+age);

//String interpolation necessary to add $ first  
Console.WriteLine($"my name is {name} and my age is {age}");

// break - to jump out from the switch / loop
// continue - The continue statement breaks one iteration (in the loop),
// if a specified condition occurs, and continues with the next iteration in the loop.

//Arrays
string[] names = new string[5];

// taking array inputs using loop
Console.WriteLine("taking array inputs");
for(int i = 0; i<5; i++)
{
    names[i] = Console.ReadLine() ?? "Default Name";
}
 Console.WriteLine();

// print array using foreach
  Console.WriteLine("printing array names");
foreach(string n in names)
{
    Console.WriteLine(n);
}

//arrayName.Length --> returns no of elements in array
//Array.Sort(arrayName) --> sorts the array
// using System.Linq; --> array direct function like min, max, sum | arrayName.sum

}

}