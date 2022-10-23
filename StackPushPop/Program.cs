using System.Drawing;

namespace StackPushPop
{
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
                Console.WriteLine("Stack Overflow");
                return;
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
                Console.WriteLine("Stack is Empty");
               
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
                Console.WriteLine("Stack is Empty");
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
                    Console.WriteLine("enter element");
                    int element = int.Parse(Console.ReadLine());
                    stack.push(element);

                }
                else if (option == 2)
                {

                    stack.pop();
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