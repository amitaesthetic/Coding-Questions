using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{
    public static int[] TraditionalBubbleSort(int[] listofInt)
    {
        for (int i = 0; i < listofInt.Length - 1; i++)
        {
            for (int j = 0; j < listofInt.Length - 1; j++)
            {
                if (listofInt[j] > listofInt[j+1])
                {
                    var tmp = listofInt[j];
                    listofInt[j] = listofInt[j+1];
                    listofInt[j+1] = tmp;
                }
            }
        }

        return listofInt;
    }
    
    public static int[] BetterBubbleSort(int[] listofInt)
    {
        var size = listofInt.Length-1;

        for (int i = 0; i < listofInt.Length-1; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (listofInt[j] > listofInt[j+1])
                {
                    var tmp = listofInt[j];
                    listofInt[j] = listofInt[j+1];
                    listofInt[j+1] = tmp;
                }
            }
            size--;
        }

        return listofInt;
    }

    static void Main(String[] args)
    {
        int[] abc = {21,17,20,32,19,33,1,4,3,2, 5, 2, 52, 23, 10, 7};

        var baskets = BetterBubbleSort(abc);

        foreach(var a in baskets)
        {
            Console.WriteLine(a+"\t");
        }

        Console.ReadLine();
    }
}
