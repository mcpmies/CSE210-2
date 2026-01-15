using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;
        int zero = 0;
        int sum = 0;
        int greatest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number:  ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        } while (input != 0);

        numbers.Remove(zero);

        foreach (int num in numbers)
        {
           sum += num;
           if (num > greatest)
            {
                greatest = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count}");
        Console.WriteLine($"The largest number is {greatest}");
    }
}