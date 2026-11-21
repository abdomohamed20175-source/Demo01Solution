using System.Runtime.InteropServices;
using System.Text;




namespace Practice
{
    internal class Program
    {
       public void print(int age,string name="no name")
        {
            Console.WriteLine($"hello {name} age :{age}");
        }
        static void Main(string[] args)
        {



          Program p=new Program();
            p.print(name:"moahemd",age:9);




        }
    }
}
