/*  Create an algorithm to determine the largest of a series of numbers that are read from the keyboard.
    The user ends by entering -1. */

using System;
using System.Collections.Generic;

class Program5
{
    static void Main(string[] args)
    {
        string sinput ;
        int input=0;
        List<int> numList = new List<int>();

        while (input != -1)
        {
            Console.Write("Input a number: ");
            sinput = Console.ReadLine();
            input = Convert.ToInt32(sinput);

            numList.Add(input);
        }

        numList.RemoveAt(numList.Count-1);

        /*
        foreach (int val in numList)
        {
            Console.WriteLine(val);
        }
        */

        Console.WriteLine("\nTHE TOTAL COUNT OF INPUT NUMBER(S) IS " + numList.Count);
        Console.WriteLine("THE GREATEST NUMBER IS " + numList.Max());

        numList.Clear();

    }
}