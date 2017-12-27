using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
      var frequency = new int[char.MaxValue];

      var result = new Dictionary<char, int>();

      foreach(var t in str)
      {
        frequency[t]++;
      }

      for(var i = 0; i < (int)char.MaxValue; i++)
      {
          if (frequency[i] > 0 && char.IsLetterOrDigit((char)i))
          {
            result.Add((char)i, frequency[i]) ;

          }
      }

      return result;
    }
}
