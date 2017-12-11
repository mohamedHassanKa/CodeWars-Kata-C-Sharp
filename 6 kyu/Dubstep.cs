using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
           var strings = new List<string>();
            var str = Regex.Split(input,"WUB");

            for(var i = 0; i< str.Length; i++)
            {
                if(str[i] != "")
                {
                    strings.Add(str[i]);
                }
            }

            return string.Join(" ", strings);
        }
    }
