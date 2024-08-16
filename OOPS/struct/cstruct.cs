 /* 

 Why struct -> it is value typed means it does not require and additional memory  
 it stores data of vaiable in the same memory which is allocate for variavble

 Refrence type memory -> it need extra memory for storing it's metadata
 eg one obj is person and it has it's own metadata like name , age etc..

 pupose: when to use 
 Ideal for small, simple data structures that do not require inheritance or 
 polymorphism. | when we want to improve memory performence 

*/

public struct Person
{

   string name;
   int age;

   public  Person(string n, int a) 
   {
        name = n; 
        age = a;
   }

   public void info()
   {
     Console.WriteLine("name "+name+" age "+age);
   }
      
}