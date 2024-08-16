// Aggregation : has a realtionship
/*
 Let's see an example of aggregation where person class has the reference of 
 Address class as data member. In such way, it can reuse the members of Address
 class.
*/

public class Person   
{
  string name;
  int age;
  

  Address address; // has a relationship

  public void info(int age, string name, Address address)
  {
     this.age = age;
     this.name = name;
     this.address = address;
     Console.WriteLine("name: "+name+" age: "+age);
     Console.WriteLine("city: "+address.city+" street: "+address.street+" pincode: "+address.pincode);
  }
}

public class Address 
{
 public string city, street;
  public  int pincode;

  public Address(int pincode, string city, string street)
  {
     this.pincode = pincode;
     this.city = city;
     this.street = street;
  }
}

public class Aggregation
{
      public static void Main()
      {
        Address a1 = new Address(01,"nyc","wallst");
        Person p1 = new Person();
        p1.info(20,"alex",a1); 
      }
}


