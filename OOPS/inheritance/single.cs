public class Activity // base class 
{ 
    string activity = "";

    public void SetFavActivity(string ac)
    {
        this.activity = ac;
        Console.WriteLine("my favourite activity is: "+activity);
    }

}

public class Person : Activity  // derive class
{
    int age;
    string name;

  public Person(int a, string n)
    {
        name = n;
        age = a;
    }

    public void info()
    {
        Console.WriteLine("name is "+name+" age is "+age);
    }

}  

public class Single
{
    public static void Main()
    {
        Activity a1 = new Activity();
        
        Person p1 = new Person(20,"alex");
        p1.info();
        p1.SetFavActivity("coding");

    }
}