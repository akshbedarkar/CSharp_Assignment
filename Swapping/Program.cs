namespace Swapping
{
    public class Program
    {

        public static void swap(int number1,int number2 )
        {
            int temp = 0;

            temp = number2;
            number2 = number1;
            number1 = temp;

            Console.WriteLine($"the swapped values are number1:{number1} and number2 :{number2}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the numbers you want to swap");
            int number1=int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 1 if you want to perform swapping operation");
            int option = int.Parse(Console.ReadLine());


            if (option !=1)
            {
                return;
            }
            else
            {
                swap(number1 ,number2);
            }

        }
    }
}