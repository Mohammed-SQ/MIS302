using System;
class Compareisons
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber == secondNumber)
        {
            if (secondNumber == thirdNumber)
            {
                Console.WriteLine("All numbers are equal");
            }
        }
        if (firstNumber != secondNumber)
        {
            if (firstNumber != thirdNumber)
            {
                if (secondNumber != thirdNumber)
                {
                    Console.WriteLine("All numbers are different");
                }
            }
        }
        int largest = firstNumber;
        if (largest < secondNumber)
        {
            largest = secondNumber;
        }

        if (largest <= thirdNumber)
        {
            largest = thirdNumber;
        }

        Console.WriteLine("Largest number: " + largest);

        int smallest = firstNumber;
        if (smallest > secondNumber)
        {
            smallest = secondNumber;
        }

        if (smallest >= thirdNumber)
        {
            smallest = thirdNumber;
        }
        
        Console.WriteLine("Smallest number: " + smallest);
    }
}
    