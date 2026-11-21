namespace Project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your salary");
            long salary = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($" age:{age} name:{name}   salary:{salary} ");
        }
    }
}
