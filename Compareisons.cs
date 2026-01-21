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
        int largest = firstNumber;
        if (secondNumber > largest)
        {
            largest = secondNumber;
        }
        if (thirdNumber > largest)
        {
            largest = thirdNumber;
        }
        Console.WriteLine("The largest number is: " + largest);
    }
}