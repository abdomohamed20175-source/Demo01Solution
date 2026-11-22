using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task2
{
    internal class Program
    {
        //static  void PrintFirstBook(int]) {}
        static void Main(string[] args)
        { // question 1

            string title = "clean code";
            string titleToUpper = title.ToUpper();
            Console.WriteLine($" title : {title}  ,titleToUpper : {titleToUpper} ");
            //question 2
            Console.WriteLine("--------------------------");
            string var01 = "clean code";
            string var02 = "clean code";
            Console.WriteLine(ReferenceEquals(var01, var02)); //return true

            // question 3
            Console.WriteLine("--------------------------");
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("- Updated");
            Console.WriteLine($" final result after append  : {sb}");

            // question 4
            Console.WriteLine("--------------------------");
            sb.Replace("Book List", "Library");
            Console.WriteLine($" final result after replace  :  {sb} ");

            // qustion 5
            Console.WriteLine("--------------------------");
            string title01 = "clean code";
            int pages = 464;
            Console.WriteLine("Book :" + title01 + "  pages  : " + pages);
            // question 6
            Console.WriteLine($"Book :{title01} Pages : {pages}");
            // question 7

            string result = string.Format("title:{0}  pages:{1}", title01, pages);
            //question 8
            Console.WriteLine("--------------------------");
            int page = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            // question 9
            Console.WriteLine("--------------------------");
            page = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable is true)
            {
                Console.WriteLine("you can borrow this book");
            }
            else
            {
                Console.WriteLine("you canNot borrow this book");
            }
            // question 10
            Console.WriteLine("--------------------------");
            string refctor = "refactoring";
            switch (refctor)
            {
                case "clean code":
                    Console.WriteLine("Great choice!");
                    break;
                case "refactoring":
                    Console.WriteLine("Nice Pick");
                    break;
                default:
                    Console.WriteLine("Never heard of it ");
                    break;
            }

            // question 11
            Console.WriteLine("--------------------------");
            int numberOfPages = 464;
            string size = numberOfPages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(size);

            // quetion 12
            string[] books = { "Clean code", "The Pragmatic Programmer", "Refactoring" };
            Console.WriteLine("With For");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"The Book number {i + 1}  is : {books[i]}  ");
            }
            Console.WriteLine("--------------------------");
            //quetion 13

            Console.WriteLine("-----------------------------");
            Console.WriteLine("With While");
            int counter = 0;
            while (counter < books.Length)
            {
                Console.WriteLine($"The Book number {counter + 1}  is : {books[counter]}  ");
                counter++;


            }


            //question 14
          
            Console.WriteLine("--------------------------");
            Console.WriteLine("with Do while");
            int count = 0;
            do
            {

                Console.WriteLine($"The Book number {count + 1}  is : {books[count]}  ");

                count++;

            } while (count < books.Length);

          

            //question 15

            Console.WriteLine("with  foreach");
            foreach (string i in books)
            {

                Console.WriteLine($"The book is : {i}");
            }
            Console.WriteLine("--------------------------");


            //question 16
            Console.WriteLine("to break");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                    break;
                Console.WriteLine($"The Book number {i + 1}  is : {books[i]}  ");





            }
            Console.WriteLine("****************************");
            //question 17

            Console.WriteLine("to continue");

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine($"The Book number {i + 1}  is : {books[i]}  ");

            }
            // question 18


            //PrintFirstBook(string[] books);

            static void PrintFirstBook(Book[] books)
            {
                if (books.Length == 0)
                    return;

                Console.WriteLine(books[0]);

            }
      
        }
    }
}
