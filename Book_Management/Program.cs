using System.Reflection;

namespace Book_Management
{
    public enum booktype
    {
        Magazine=1,
        Novel=2,
        ReferenceBook=3,
        Miscellaneous=4,
    }


    public struct book
    {
        int bookid;
        string title;
        int price;

        static void Main(string[] args)
        {
            book book1 = new book();
            booktype type1 = new booktype();

            //user input 
            Console.WriteLine("Enter the Book Details");

            Console.WriteLine("Enter the Book Id");
            book1.bookid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Title");
            book1.title = (Console.ReadLine());

            Console.WriteLine("Enter the Price");
            book1.price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the book reference \n 1.Magazine \n 2.Novel \n 3.ReferenceBook \n 4. Miscellaneous");
            
            int option = int.Parse(Console.ReadLine());


            //2.display details of book
            if (option >0 && option<5)
            {

                Console.WriteLine($"The book details are : \n BookId :{book1.bookid} \n Title :{book1.title} \n Price:{book1.price} \n Reference type is {(booktype)option}");
            }
            else
            {
                Console.WriteLine("Mention the correct Book Reference");
            }
            

        }
    }
}