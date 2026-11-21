namespace Day1Route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter you name");
            string studentName=Console.ReadLine();
            Console.WriteLine("enter your Age");
            int age=Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 3; i++) {
                Console.WriteLine($"enter your Grade:{i}");
               int grade=Convert.ToInt32(Console.ReadLine());
                sum += grade;
            }
            Console.WriteLine($"sum={sum}   average={sum/3}");
            if((sum/3)>=50)
                Console.WriteLine("you passed");
            else
                Console.WriteLine("you failed");
            if(age>=18)
                Console.WriteLine("Adult");
            else 
                Console.WriteLine("Minor");
        }
    }
}
