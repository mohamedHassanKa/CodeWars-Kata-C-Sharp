public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
     var smileyIcons = new string[] { ":)", ";)", ":D", ";D", ":-)", ":~)", ";-)", ";~)", ":-D", ":~D", ";-D", ";~D"};

     var count = 0;
     for(var i = 0; i < smileys.Length; i++)
     {
       for(var j = 0; j < smileyIcons.Length; j++)
       {
         if (smileys[i] == smileyIcons[j])
         {
            count += 1;
         }
       }
               
      }

      return count;
  }
}
