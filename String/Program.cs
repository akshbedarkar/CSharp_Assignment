using System;

namespace String
{
    public class String
    {
        static void sort(string[] name)
        {
            Array.Sort<string>(name); // Sort array.
            foreach (var s in name)
                Console.WriteLine(s);
        }

        static void reverse(string[] name)
        {
            Array.Reverse<string>(name); // Sort array.
            foreach (var s in name)
                Console.WriteLine(s);
        }

        static void copy(string[] name)
        {
            Console.WriteLine("Size of your new array");
            int size = int.Parse(Console.ReadLine());
            string[] newarray = new string[size];
            Console.WriteLine("how many elements you want to copy");
            int index = int.Parse(Console.ReadLine());
            Array.Copy(name, 0, newarray, 0, index);


            foreach(string i in newarray)
            {
                Console.WriteLine(i);
            }
        }
        static void clear(string[] name)
        {
            Console.WriteLine("Enter the index number from where you want to clear elements");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("how many elements you want to clear");
            int length = int.Parse(Console.ReadLine());

            Array.Clear(name, index, length);
            foreach (string i in name)
            {
                Console.WriteLine(i);
            }
        }



        static void Main(string[] args)
        {
            string[] name = { "akshata", "mansi", "rupali", "arpita", "anisha","zain" };

            while (true)
            {
                Console.WriteLine("operation to perform on string :\n 1.Sort \n 2.Reverse \n 3.Copy \n 4.Clear 5.Exit");
                int option = int.Parse(Console.ReadLine());

            
                if (option == 1)
                {
                    sort(name);
                }
                else if (option == 2)
                {
                    reverse(name);
                }
                else if (option == 3)
                {
                    copy(name);

                }
                else if (option == 4)
                {
                    clear(name);
                }
                else if (option == 5)
                {
                    break;
                }
            }



        }
    }
}


