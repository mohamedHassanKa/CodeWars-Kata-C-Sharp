using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
      var countOne = 0;
      var countTwo = 0;

      for (var i = 0; i < input.Length; i++)
      {
          if (input[i] == 'x' || input[i] == 'X')
          {
              countOne++;
          }

          if (input[i] == 'o' || input[i] == 'O')
          {
              countTwo++;
          }
      }

      return (countOne == countTwo)  ? true : false;
    }
}
