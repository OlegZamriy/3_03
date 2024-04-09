using _3_03;
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 3 };
        IntArray intArray = new IntArray(numbers);

        intArray.Show();

        Console.WriteLine("Sorted in ascending order:");
        intArray.SortAsc();
        intArray.Show();

        Console.WriteLine("Sorted in descending order:");
        intArray.SortDesc();
        intArray.Show();

        Console.WriteLine("Sorted by parameter (ascending):");
        intArray.SortByParam(true);
        intArray.Show();

        Console.WriteLine("Sorted by parameter (descending):");
        intArray.SortByParam(false);
        intArray.Show();
    }
}
