/* 
    Abstraction is about hiding the details and providing a base with shared behavior.
    Use abstract classes when you want to provide common behavior

    here in this example we shapemethods as common behaviour class and share it 
    with circle and rectangle class
*/

public abstract class ShapeMethods
{
    public abstract void DrawShape();
    public abstract void FillColor(string color);
    public abstract void Border(string Bcolor);
}

public class Circle : ShapeMethods
{

    public override void DrawShape()
    {
        Console.WriteLine("Drawing circle");
    }
    public override void FillColor(string color)
    {
         Console.WriteLine("filling cirle with "+color+" color");
    }
    public override void Border(string Bcolor)
    {
         Console.WriteLine("circle border color "+Bcolor);
    }

}


public class Rectangle : ShapeMethods
{
         public override void DrawShape()
    {
        Console.WriteLine("Drawing Rectangle");
    }
    public override void FillColor(string color)
    {
         Console.WriteLine("filling Rectangle with "+color+" color");
    }
    public override void Border(string Bcolor)
    {
         Console.WriteLine("Rectangle border color "+Bcolor);
    }

}

public class abstract1 
{
    public static void Main()
    {
        ShapeMethods c1 = new Circle();
        c1.DrawShape();
        c1.FillColor("Red");
        c1.Border("black");
        Console.WriteLine();

        ShapeMethods r1 = new Rectangle();
        r1.DrawShape();
        r1.FillColor("blue");
        r1.Border("black");
        Console.WriteLine();
    }
}