using System;
class CandidateCode
{
    public static int[] SelectionSort(int[] listofInt)
    {
        
        for (int i = 0; i < listofInt.Length-1; i++)
        {
            var min = i;
            var temp = listofInt[i];

            for (int j = i+1; j < listofInt.Length-1; j++)
            {
                if(listofInt[j] < listofInt[min])
                {
                    min=j;
                }
            }

            listofInt[i] = listofInt[min];
            listofInt[min] = temp;
        }

        return listofInt;
    }

    static void Main(String[] args)
    {
        int[] abc = {21,17,20,32};

        var baskets = SelectionSort(abc);

        foreach(var a in baskets)
        {
            Console.WriteLine(a+"\t");
        }

        Console.ReadLine();
    }
}
