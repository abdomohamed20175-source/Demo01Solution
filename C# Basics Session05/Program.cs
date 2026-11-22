namespace C__Basics_Session05
{
    enum Genre
    {
        Fiction = 1,
        NonFiction = 2,
        Science = 3
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //question 1
            Book book = new Book();
            // Console.WriteLine(book.password);  Comiler Error
            Console.WriteLine("Comiler Error");

            Console.WriteLine("----------------------");
            // question 2

            Console.WriteLine(book.copiesInStock); // compile bec: CopiesInStock is internal
            Console.WriteLine("----------------------");
            //qustion 3

            book.Title = "C# Basics For .NET Developers";
            Console.WriteLine(book.Title);
            Console.WriteLine("----------------------");
            //question 4
            book.genre = Genre.Science;
            Console.WriteLine(book.genre);
            Console.WriteLine("----------------------");

            //question 5
            int genre01 = (int)Genre.Fiction;
            Console.WriteLine(genre01);
            int genre02 = (int)Genre.NonFiction;
            Console.WriteLine(genre02);
            int genre03 = (int)Genre.Science;
            Console.WriteLine(genre03);
            Console.WriteLine("----------------------");

            //question 6
            int genreNumber = 1;
            Genre cast = (Genre)genreNumber;
            Console.WriteLine(cast);
            Console.WriteLine("----------------------");
            //question 7
            Genre genre = Genre.Fiction;
            string x = genre.ToString();
            Console.WriteLine(x);
            Console.WriteLine($" For Check :{x.GetType()}");
            Console.WriteLine("----------------------");
            //question 8
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(parsedGenre);
            Console.WriteLine($" For Check :{parsedGenre.GetType()}");
            Console.WriteLine("----------------------");
            //question 9
            string genreText02 = "Mystery";
            //Genre parsedGenre02 = (Genre)Enum.Parse(typeof(Genre),genreText02);  Runtime Error
            //Console.WriteLine(parsedGenre02);

            Console.WriteLine("----------------------");
        }
    }
}
