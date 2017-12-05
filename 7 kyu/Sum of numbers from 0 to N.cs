//Sum of numbers from 0 to N
public class SequenceSum
{
  public static string ShowSequence(int n)
  {    
    var answer = "";
    var temp = "";
    var count = 0;


    if (n < 0)
    {
      count = n;
      answer = count + "<0";
    }

    if (n == 0)
    {
      count = n;
      answer = count + "=0";
    }

     for (int i = 0; i <= n; i++)
     {
       if(n > 0)
       {
         count += i;
         temp += i + "+";
         answer = temp.TrimEnd('+') + " = " + count;
       }
                
      }

      return answer;
   }  
}
