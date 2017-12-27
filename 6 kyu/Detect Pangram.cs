using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool IsPangram(string str)
  {
      var alphabet = "abcdefghijklmnopqrstuvwxyz";

      var items = new List<char>();
      
      var strToLower = str.ToLower();

      for(var i = 0; i < alphabet.Length; i++)
      {
        for(var j = 0; j < strToLower.Length; j++)
        {
            if (strToLower[j] == (alphabet[i]))
            {
                if (!items.Contains(alphabet[i]))
                {
                    items.Add(alphabet[i]);
                }

            }
          }
                
        }

        return items.Count >= 26 ? true : false;
    }
}
