namespace ARRAY
{
    public  class array
    {

        
        static void Main(string[] args)
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            
            
            while(true)
            {
                Console.WriteLine("operation to perform on array :\n 1.Sort \n 2.Reverse \n 3.Copy \n 4.Clear 5.exit");
                int option = int.Parse(Console.ReadLine());



                if (option == 1)
                {
                    Array.Sort(array);
                    foreach (object obj in array)
                    {
                        Console.WriteLine(obj);
                    }
                }
                else if (option == 2)
                {
                    Array.Reverse(array);
                    foreach (object obj in array)
                    {
                        Console.WriteLine(obj);
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("enter the size of array");
                    int size = int.Parse(Console.ReadLine());
                    int[] newarray = new int[size];
                    Console.WriteLine("new array is created");
                    Console.WriteLine("how many elements you want to copy");
                    int number = int.Parse(Console.ReadLine());
                    if (number > array.Length)
                    {
                        Console.WriteLine("the original array contains only 5 elements");
                    }
                    else
                    {
                        Array.Copy(array, 0, newarray, 0, number);
                        foreach (object obj in newarray)
                        {
                            Console.WriteLine(obj);
                        }
                    }

                }
                else if (option == 4)
                {
                    Console.WriteLine("how many elements you want to clear");
                    int clear = int.Parse(Console.ReadLine());
                    Console.WriteLine("From which index");
                    int index = int.Parse(Console.ReadLine()) - 1;


                    Array.Clear(array, index, clear);
                    foreach (object obj in array)
                    {
                        Console.WriteLine(obj);
                    }
                }
                else if (option == 5)
                {
                    break;
                }
            }
            
               

           
            
            


        }
    }
}