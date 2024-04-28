using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbersList = new List<int>();;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbersList.Add(number);
        } 

        int sum = 0;
        float average = 0;
        int largest = 0;

        //Console.WriteLine($"The number of numbers in the list is {numbersList.Count}");
        for (int i = 0; i < numbersList.Count; i++)
        {
            //Console.WriteLine(numbersList[i]);
            sum += numbersList[i];
            if (largest < numbersList[i])
            {
                largest = numbersList[i];
            }
        }

        average = (float)sum / (float)(numbersList.Count -1) ;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        
    }
}