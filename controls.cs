using System;

public class Controls
{
    // for loop | break
    public static void Main(string[] args)
    {
        for (int i = 0; i <= 5; i++)
        {
            if (i == 3)
            {
                break; // this will get out from entire loop

            }
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // while loop | Continue
        int j = 0;
        while (j <= 5)
        {
            if (j == 3)
            {
                j++;
                continue; // this will skip the iteration 

            }
            Console.WriteLine(j);
            j++;
        }


        // goto statemet | if-else

        for (int k = 0; k <= 10; k++)
        {
            Console.Write(k);
            if (k % 2 == 0)
            {
                goto even;
            }
            else
            {
                goto odd;
            }

        even:
            Console.WriteLine(" is even");
            continue;

        odd:
            Console.WriteLine(" is odd");
            continue;
        }

    }
}