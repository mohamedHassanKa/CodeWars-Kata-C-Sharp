using System;
using System.Collections.Generic;
using System.Linq;

public class SumSquaredDivisors 
{
	
	public static string listSquared(long m, long n)
  {
      var result = new List<string>();

      for(var i = m; i <= n; i++)
      {
          var sumOfSquareDivs = Divisors(i).Select(x => x * x).Sum();
          
          if (IsSquared(sumOfSquareDivs))
          {
              result.Add($"[{i}, {sumOfSquareDivs}]");
           }
        }
        return"[" + String.Join(", ", result) + "]";
        
    }

    private static IEnumerable<long> Divisors(long input)
    {
        for(var i = 1; i <= input; i++)
        {
            if(input % i == 0)
            {
                yield return i;
            }
        }
    }

    private static bool IsSquared(long num)
    {
        var squareRoot = Math.Sqrt(num);

        return ((int)squareRoot * (int)squareRoot == num);
    }
}
