using System;
using System.Collections.Generic;
using System.Linq;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
        var digits = new List<long>();

        for (var i = a; i <= b; i++)
        {
            if (i.ToString().Select((c, j) => Math.Pow(Char.GetNumericValue(c), j + 1)).Sum() == i)
            {
                digits.Add(i);
            }
                    
        }
        
        return digits.ToArray();
    }
    
}
