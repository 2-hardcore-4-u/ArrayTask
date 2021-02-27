using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());

        List<int> prevOne = new List<int>();
        List<int> thisOne = new List<int>();

        int counter = 0;
        int actualNumber = R;

        thisOne.Append(R);
        prevOne.Append(R);
        Console.WriteLine(thisOne.Count);
        for(int i = 1; i <= L; i++)
        {
            prevOne = new List<int>(thisOne);
            int l = prevOne.Count;
            actualNumber = prevOne[0];
            for (int j = 0; j < l-1; j++)
            {
                if (prevOne[j] == prevOne[j++])
                {
                    counter++;
                }
                else
                {
                    thisOne.Append(counter);
                    thisOne.Append(actualNumber);
                }
            }
            foreach (int x in thisOne)
            {
                Console.Write(x);
                Console.Write(' ');
            }
        }

        foreach (int x in thisOne)
        {
            Console.Write(x);
            Console.Write(' ');
        }
    }
}