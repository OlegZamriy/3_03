using _3_03;
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        IntArray intArray = new IntArray(numbers);

        intArray.Show();
        Console.WriteLine($"Max: {intArray.Max()}");
        Console.WriteLine($"Min: {intArray.Min()}");
        Console.WriteLine($"Avg: {intArray.Avg()}");
        Console.WriteLine($"Search for 3: {intArray.Search(3)}");
        Console.WriteLine($"Search for 10: {intArray.Search(10)}");
    }
}
