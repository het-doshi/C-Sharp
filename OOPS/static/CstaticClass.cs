public static class MathFun
{
 
  /* 
    A static class is a class that cannot be instantiated. 
    All members of a static class must be static.

    purpose: It's used for grouping related methods or properties that don’t rely on 
    object instances.

  */

   public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Min(int a, int b)
    {
        if(a<b)
         return a;
        else 
          return b;
    }

}