using System.Collections.Generic;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
     var items = new List<char>();

     for (var i= 0; i < str.Length; i++)
     {
        if (char.IsUpper(str[i]))
        {
            items.Add(' ');
        }

        items.Add(str[i]);
     }

     return string.Join("", items);
  }
}
