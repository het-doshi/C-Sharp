using System;

public class Cenum
{
    enum WeekDays{
    n,
    mon,
    tue,
    wed,
    thr,
    fri,
    sat
}

 public static void Main()
 {
    Console.WriteLine((WeekDays)1);

    int no = (int)WeekDays.mon;
    Console.WriteLine(no);
 }
   
}