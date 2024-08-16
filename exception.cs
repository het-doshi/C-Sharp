/* 
    Exception Handling in C# is a process to handle runtime errors. We perform 
    exception handling so that normal flow of the application can be maintained even 
    after runtime errors.

    All the exception classes in C# are derived from System.Exception class. 
    Let's see the list of C# common exception classes.

    System exceptions
    DivideByZeroException
    NullReferenceException
    InvalidCastException
    IOException
    FieldAccessException

    user defined exceptions
    C# allows us to create user-defined or custom exception. It is used to make the 
    meaningful exception. To do this, we need to inherit Exception class.

    checked exception throw error when arithmethic value is overflows
    check overflow and conversion of integral type values at compile time.

    unchecked exception not throw error when arithmethic value is overflows
*/


// user defined exception
public class CPIException : Exception  
{  
    public CPIException(String message) : base(message)  
    {  
  
    }  
}  

public class Exception1
{

    // user defined exception
    static void Eligiblity(int cpi)  
    {  
      if (cpi < 7.0)  
      {  
        throw new CPIException("cpi must be greater than 7");  
      }  
    }  


   public static void Main()
  {
    
     /*
        In C# programming, exception handling is performed by try/catch statement. 
        The try block in C# is used to place the code that may throw exception. 
        The catch block is used to handled the exception. The catch block must be 
        preceded by try block.

        C# finally block is used to execute important code which is to be executed
        whether exception is handled or not. It must be preceded by catch or try 
        block.
      */

    // system exceptions
     try  
        {  
            int a = 10;  
            int b = 0;  
            int x = a / b;  
        }  
        catch (Exception e) 
        { 
          Console.WriteLine(e);  
          Console.WriteLine("code continue..");  
        }  
        finally 
        { 
            Console.WriteLine("Finally block is executed"); 
        }  
       
       Console.WriteLine();
        Console.WriteLine();

     // using user define exception
       try  
        {  
            Eligiblity(6);  
        }  
        catch (CPIException e) 
        { 
            Console.WriteLine(e); 
        }  
        finally
        {
            Console.WriteLine("NOW SKILL UP");  
        }
    }  
}