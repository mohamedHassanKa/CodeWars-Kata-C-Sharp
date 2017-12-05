//Disemvowel Trolls

using System;

public static class Kata
{
  public static string Disemvowel(string str)
  {
      var temp = str;
      var vowels = new string[] 
      {
         "a","A","e","E","u","U","i","I","o","O",
      };

      foreach(var item in vowels)
      {
          if (str.Contains(item))
          {
              temp = str.Replace(item, string.Empty);
          }

          str = temp;
       } 

       return str;
  }
}
