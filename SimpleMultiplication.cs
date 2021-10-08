/*
This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
*/

public class Multiplier
{
  public static int Multiply(int x) 
  {
    if (x % 2 == 0)
      {
        x = x * 8;
          return x;
      }
    else
     {
      x = x * 9;
        return x;
      }
  }
} 
