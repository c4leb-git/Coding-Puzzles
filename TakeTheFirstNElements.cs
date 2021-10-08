/*
Create a method take that accepts a list/array and a number n, and returns a list/array array of the first n elements from the list/array.

If you need help, here's a reference:

https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1 
*/

using System.Linq;

public static class Kata
{
    public static int[] Take(int[] arr, int n) => arr.Take(n).ToArray();
}
