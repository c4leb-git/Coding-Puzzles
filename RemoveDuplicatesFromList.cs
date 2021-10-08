/* Define a function that removes duplicates from an array of numbers and returns it as a result.

The order of the sequence has to stay the same. */


using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a) 
      {
        int[] dist = a.Distinct().ToArray();
        return dist;
      }
  }
}
