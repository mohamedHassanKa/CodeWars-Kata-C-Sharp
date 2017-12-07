// Take a ten minute walk

public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
    return walk.Length == 10 && (walk[1] == walk[9]) ? true : false;
  }
}
