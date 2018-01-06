using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BinaryNumbers
{
  public static string Add(string a, string b)
  {
      var firstStringToInt =  BitStringToInt(a);
      var secondStringToInt = BitStringToInt(b);

      var sum = firstStringToInt + secondStringToInt;

      var sumToBinary = Conversion2(sum);

      sumToBinary.Remove(sumToBinary[0]);
      
      var result = string.Join("", sumToBinary);
      return result == string.Empty ? "0" : result;
  }
  
  public static int BitStringToInt(string bits)
  {
      var reversedBits = bits.Reverse().ToArray();
      var num = 0;
      for (var power = 0; power < reversedBits.Count(); power++)
      {
        var currentBit = reversedBits[power];
        if (currentBit == '1')
        {
          var currentNum = (int)Math.Pow(2, power);
          num += currentNum;
        }
      }

      return num;
    }
    
    public static List<string> Conversion2(int x)
    {
        var bitConversion = new List<string>();
        while (x >= 0)
        {
          if (x == 0)
          {
          bitConversion.Add("0");
          break;
          }
          bitConversion.Add((x % 2).ToString(CultureInfo.InvariantCulture));
          x /= 2;
        }
        bitConversion.Reverse();
        return bitConversion;
    }
}
