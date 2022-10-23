using System.Drawing;

namespace StackPushPop
{
    public class StackException: Exception
    {
        public StackException(String message)
            : base(message)
        {

        }
    }
    public class Mystack 
    {
        private int[] array;
        private int top;
        private int max;

        Mystack(int size)
        {
            array = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            
                if (top == max - 1)
                {
                    throw new StackException("Stack is Full");
            }
                else
                {
                    array[++top] = item;
                }
            
            
            
            

        }
        public int pop()
        {
            if (top == -1)
            {
                throw new StackException("Stack is Empty");

            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    return array[top--];
                }
            }
            return 0;
        }
        public void printStack()
        {
            if (top == -1)
            {
                throw new StackException("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + array[i]);
                }
            }
            
        }





        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size = int.Parse(Console.ReadLine());
            Mystack stack = new Mystack(size);

            while(true)
            {
                Console.WriteLine("option : 1.push 2.pop 3.display  4.exit");
                int option = int.Parse(Console.ReadLine());



                if (option == 1)
                {
                    try
                    {
                        Console.WriteLine("enter element");
                        int element = int.Parse(Console.ReadLine());

                        stack.push(element);

                    }
                    catch (StackException e) { Console.WriteLine(e); }
                   
                }
                else if (option == 2)
                {
                    try
                    {
                        stack.pop();
                    }
                    catch (StackException e) { Console.WriteLine(e); }

                }

                else if (option == 3)
                {
                    stack.printStack();
                }
                else if (option == 4)
                {
                    break;
                }

            }
            


            



        }   
    }
}