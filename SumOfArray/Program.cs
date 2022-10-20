using System;
using System.Drawing;

namespace SumOfArray
{
    internal class Program
    {
        public class Calculate
        {

            public void addition(int[] array)
            {
                int result = 0;
                foreach (int i in array)
                {
                    
                    result += i;

                }
                Console.WriteLine("the sum of entered number is " + result);

            }


            static void Main(string[] args)
            {
                Calculate c = new Calculate();
                Console.WriteLine("How many numbers you want to enter");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];
                Console.WriteLine("enter the numbers you want to add");

                for (int i = 0; i < size; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                c.addition(array);







            }
        }
        
        
    }
}