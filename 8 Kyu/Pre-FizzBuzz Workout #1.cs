// Pre-FizzBuzz Workout #1

using System.Collections.Generic;

public class Kata
{
  public static int[] PreFizz(int n) 
  {
    var myList = new List<int>();
    for(var count = 1; count <= n; count++)
    {
        myList.Add(count);
    }

    var array = myList.ToArray();

    return array;
  }
}
