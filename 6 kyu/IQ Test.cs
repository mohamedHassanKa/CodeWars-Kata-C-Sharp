using System;
using System.Linq;
using System.Collections.Generic;

public class IQ
    {
        public static int Test(string numbers)
        { 
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            var array = numbers.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            for(var i = 0; i < array.Length; i++)
            {
                 if (Convert.ToInt32(array[i]) % 2 == 0)
                 {
                     evenNumbers.Add(i + 1);
                 }

                 if (Convert.ToInt32(array[i]) % 2 != 0)
                 {
                     oddNumbers.Add(i + 1);

                 }

            }

            return (evenNumbers.Count > oddNumbers.Count) ? oddNumbers[0] : evenNumbers[0];
        }
    }
