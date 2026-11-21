namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //qustion1
            Book book1 = new Book();
            book1.Title = "designPattern";
            book1.Pages = 500;
            Console.WriteLine($"Title:{book1.Title} , Pages:{book1.Pages}");
            Console.WriteLine("-----------------------------------");
            //qustion2
            Book book = new Book();
            book.Title = "CleanCode";
            book.Pages = 464;
            Console.WriteLine($"bookTitile : {book.Title} , bookPages : {book.Pages}\n");
            Console.WriteLine($"toString : {book.ToString()} bookType : {book.GetType()}\n");
            Console.WriteLine($"isEqual : {book1.Equals(book)} hashCode : {book.GetHashCode()}");
            Console.WriteLine("-----------------------------------");
           
            //question3
            bool IsParsed=int.TryParse("464",out int pages);
            if (IsParsed)
            {
                Console.WriteLine($"page: {pages}  And IsParsed is valid");
            }
            else
            {
                Console.WriteLine("TryParsed is invalid");
            }


            //quetion4
            try
            {
                int num1 = 10;
                int num2 = 0;
                Console.WriteLine($"Divide num1/num2{num1 / num2}");
            }
            catch (Exception)
            {
                Console.WriteLine("CanNot Divide by Zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine("-----------------------------");

           
            //question5
            int pages02 = 300;
            double StoredPages = pages02; // valid (smallDataType in LargeDataType)
            Console.WriteLine($"{StoredPages} \n");
            //qustion6
            double price = 49.99;
            int priceCasted = Convert.ToInt16(price);
            Console.WriteLine($"priceAfterCasting:{priceCasted}\n");
            //question7
            String pagesText = "464";
            int pagesINT = Convert.ToInt16(pagesText);
            Console.WriteLine($"pagesNumbers : {pagesINT} ");
            Console.WriteLine("-----------------------");

           
            //question8
            string yearText = "2023";
            int yearNumbers = int.Parse(yearText);
            string badText = "abc";
            bool badNumbers = int.TryParse(badText, out int badNum);
            if (badNumbers)
            {
                Console.WriteLine("TryParse is succeced");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine("-------------------------------");
            
            //question9
            int pages1 = 464;
            string str = pages1.ToString();
            Console.WriteLine($"CovertToString : {str} , GetType :{str.GetType()} ");

       
            
            // question10

            int copies = 100;
            Object boxedCopies = copies;
            int newCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(copies);

            Console.WriteLine("*******************************");
         



        }
    }
}
