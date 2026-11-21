namespace TaskSession_5
{
    enum MembershipType
    {
        Standard=1,
        Premium=2
    }
    enum Gender
    {
        Male=1,
        Female=2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();



            #region MemberID
            do
            {

                Console.WriteLine("Enter your Member ID");

                if (!int.TryParse(Console.ReadLine(), out int Id))
                {
                    Console.WriteLine("Invalid ID! Enter a valid integer.");
                }
                else if (Id < 0)
                {
                    Console.WriteLine("Enter ID greater than 0");
                }
                member.Id = Id;
            }
            while (member.Id <= 0);
            #endregion
            #region MemberName
            do
            {
                Console.Write("Enter Member Name: ");
                member.Name = Console.ReadLine();

                if (member.Name == "")
                {
                    Console.WriteLine("Name cannot be empty!");
                }

            } while (member.Name == "");
            #endregion
            #region Member Age;
            bool ageParsed;
            int age;
            do
            {
                Console.WriteLine("enter your age");
                ageParsed = int.TryParse(Console.ReadLine(), out age);
                if (!ageParsed)
                {
                    Console.WriteLine("enter aa valid age");
                }
                else if (age < 16 || age > 50)
                {

                    Console.WriteLine("please enter a valid age between 16 and 50");
                }
                member.Age = age;


            } while (!ageParsed || age < 16 || age > 50);
            #endregion
            #region Gender
            bool genderParsed;
            int gender;
            do

            {
                Console.WriteLine("enter your  Gender \n 1.Male \n 2.Female :");


                genderParsed = int.TryParse(Console.ReadLine(), out gender);

                if (!genderParsed || (gender != 1 && gender != 2))
                {
                    Console.WriteLine("Please choose a valid option (1 or 2)");
                }
                else
                {
                    member.Gender = (Gender)gender;

                }
            } while (!genderParsed || (gender != 1 && gender != 2));

            #endregion
            bool MembershipTypeParsed;
            int Membership;
            do
            {
                Console.WriteLine(" enter your member shipType \n 1. Standard \n  2. Premium");
                MembershipTypeParsed = int.TryParse(Console.ReadLine(), out Membership);
                if (!MembershipTypeParsed || (Membership != 1 && Membership != 2))
                {
                    Console.WriteLine("enter a valid membershipType ");
                }
                else
                {
                    member.MembershipType = (MembershipType)Membership;
                }
            } while (!MembershipTypeParsed || (Membership != 1 && Membership != 2));
            if (member.MembershipType == MembershipType.Standard)
            {
                member.MembershipPrice = 500;
            }
            else
            {
                member.MembershipPrice = 700;
            }
            Console.WriteLine("---------member data--------------");
            Console.WriteLine($"ID={member.Id}");
            Console.WriteLine($"NAME={member.Name}");
            Console.WriteLine($"AGE={member.Age}");
            Console.WriteLine($"Gender={member.Gender}");
            Console.WriteLine($"MembersipType={ member.MembershipType}");
            Console.WriteLine($"MembershipPrice={member.MembershipPrice}");


        }
    }
}
