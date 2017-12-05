// Find the smallest integer 
//level: 7 kyu


public class Kata
{
    public static int FindSmallestInt(int[] args) 
    {
       var smallest = args[0];

       for (var i = 1; i < args.Length; i++)
       {
            if(args[i] < smallest)
            {
                smallest = args[i];
            }
       }

       return smallest;
    }
}
