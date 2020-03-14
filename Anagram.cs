using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        //Write a program to check whether two strings are anagrams of each other or not 

        public bool CheckAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            else
            {
                Dictionary<string, int> dict1 = new Dictionary<string, int>();
                Dictionary<string, int> dict2 = new Dictionary<string, int>();

                for (int i = 0; i < str1.Length; i++)
                {
                    if (!dict1.ContainsKey(str1[i].ToString()))
                        dict1[str1[i].ToString()] = 1;
                    else
                        dict1[str1[i].ToString()] += 1;

                    if (!dict2.ContainsKey(str2[i].ToString()))
                        dict2[str2[i].ToString()] = 1;
                    else
                        dict2[str2[i].ToString()] += 1;
                }

                foreach (KeyValuePair<string, int> entry in dict1)
                {
                    if (dict2[entry.Key] != entry.Value)
                        return false;
                }
                return true;
            }
        }
        
        
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.CheckAnagrams("asadvasd","asdahsdhjasd"));
            Console.WriteLine(program.CheckAnagrams("abc", "cba"));
            Console.WriteLine(program.CheckAnagrams("xyz", "xyz"));
            Console.WriteLine(program.CheckAnagrams("asds", "assd"));
            Console.ReadLine();
        }
    }
}
