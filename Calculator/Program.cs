using System;
namespace calculator
{
    public class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to console application");
            Console.WriteLine( "1.Addtion" + "\n" + "2.Subtraction" + "\n" + "3.Multiplication" + "\n" + "4.Division");


            Console.WriteLine("Enter the 2 numbers you want to perform operation on :");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result;
            Console.WriteLine("select from the menu the operation you want to perform");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"the sum of {number1} and {number2} is {result}");
                    break;
                case 2:
                    if (number1 > number2)
                    {
                        result = number1 - number2;
                        Console.WriteLine($"the subtraction of {number1} and {number2} is {result}");
                        break;
                    }
                    else
                    {
                        result = number2 - number1;
                        Console.WriteLine($"the subtraction of {number2} and {number1} is {result}");
                        break;
                    }
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"the multiplication of {number1} and {number2} is {result}");
                    break;

                case 4:
                    if (number1 > number2)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"the division of {number2} and {number1} is {result}");
                        break;
                    }
                    else
                    {
                        result = number2 / number1;
                        Console.WriteLine($"the division of {number1} and {number2} is {result}");
                        break;
                    }
                default:
                    Console.WriteLine("enter a valid number !");
                    break;


            }
            

        }
    }
}
