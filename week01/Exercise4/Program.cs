using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating a list.");

        List<int> numbers = new List<int>();
        int number = 1;

        while (number != 0)
        {
            Console.WriteLine("Tell me a number:");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }
        int resultado = 0 + numbers.Sum();
        Console.WriteLine($"The sum of the numbers is: {resultado}");
        numbers = numbers.OrderBy(x => x).ToList();
        {
            double promedio = numbers.Average();

            Console.WriteLine($"The average is {promedio}");
        }
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number on the list is: {largestNumber}");
        int smallestNumber = numbers.Min();
        Console.WriteLine($"The smallest number on the list is: {smallestNumber}");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {numbers[i]}");
        } 



    }
}