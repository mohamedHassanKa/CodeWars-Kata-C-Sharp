// Vowel Count
//Rank : 7kyu

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var count = 0;
        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        foreach (var item in vowels)
        {
            foreach(var myString in str.Trim())
            {
                if(myString.Equals(item))
                {
                    count += 1;
                }
            }
               

        }

        return count;
    }
}
