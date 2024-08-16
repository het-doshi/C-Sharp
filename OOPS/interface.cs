/* 
  Interfaces are about defining a contract. Use interfaces to define methods that 
  must be implemented by any class, allowing for flexible and reusable code.

  When you want to achieve polymorphism and support multiple inheritance of methods.
*/

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

public interface Hardware
{
    public void SetConfiguration(string p, int r, int h, int s, string m );
}

public interface Software
{
    public void SetOs(string n, int s, string d );   
}

public class Computer : Hardware, Software
{
    public void SetConfiguration(string p, int r, int h, int s, string m )
    {
        Console.WriteLine("Hardware configuration...");
        Console.WriteLine("processor: "+p);
        Console.WriteLine("Ram: "+r+" gb");
        Console.WriteLine("hardDisk: "+h+" gb");
        Console.WriteLine("Ssd: "+s+" gb");
        Console.WriteLine("MotherBoard: "+m);
        Console.WriteLine();
    }

    public void SetOs(string n, int s, string d )
    {
        Console.WriteLine("OS Configuration...");
        Console.WriteLine($"OS: {n} size: {s}gb Drive {d}");
    }

    public static void Main()
    {
        Computer c1 = new Computer();
        c1.SetConfiguration("intel i5",8,100,512,"lenovo");
        c1.SetOs("Windows 10",80,"C:");
    }
}
