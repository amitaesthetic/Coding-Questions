using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{
    static bool isVowel(char c)
    {
        return (c == 'a' || c == 'e' || c == 'i'
                || c == 'o' || c == 'u');
    }

    static void chechpal(string s)
    {
        string revs = "";
        for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
        {
            revs += s[i].ToString();
        }
        if (revs == s) // Checking whether string is palindrome or not  
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static void Main(String[] args)
    {
        //Write code here
        string str1 = "qawedireya";

        string str2 = "adghgjfiqwe";
        List<string> strVowel1 = new List<string>();
        List<string> strVowel2 = new List<string>();

        foreach (char c in str1)
        {
            if (isVowel(c))
            {
                strVowel1.Add(c.ToString());
            }
        }

        foreach (char c in str2)
        {
            if (isVowel(c))
            {
                strVowel2.Add(c.ToString());
            }
        }

        str1 = string.Join("", strVowel1);
        chechpal(str1);
        str2 = string.Join("", strVowel2);
        chechpal(str2);
    }
}
