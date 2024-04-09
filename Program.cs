using System;

using _3_03;



class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        IntArray intArray = new IntArray(numbers);

        intArray.Show();
        intArray.Show("Test info");
    }
}


