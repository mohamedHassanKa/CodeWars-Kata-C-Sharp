// Compare Strings by Sum of Chars

using System;
using System.Linq;

public static class Kata
{
  public static bool Compare(string s1, string s2)
  { 
      var countOne = 0;
      var countTwo = 0;

       var items = new char[] 
       {
           '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=',
           '{', '}', '[', ']', '|', ';', ':', '"', ',', '.', '<', '>',
           '?', '/', '1', '2', '3', '4', '5', '6', '7', '8' ,'9', '0',
       };

       foreach (var c1 in items)
       {
           if (s1 == null ||s1.Contains(c1.ToString()))
           {
               s1 = "";
           }
        }

        foreach (var c2 in items)
        {
            if (s2 == null || s2.Contains(c2.ToString()))
            {
                s2 = "";
            }
        }

        foreach (var item in s1.ToUpper())
        {
            countOne += Convert.ToInt32(item);
        }

        foreach(var item in s2.ToUpper())
        {
            countTwo += Convert.ToInt32(item);
        }

        return (countOne == countTwo) ? true : false; 
    }
}
