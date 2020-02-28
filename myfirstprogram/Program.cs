using System;

namespace myfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string firstname = Console.ReadLine();
            
            Console.WriteLine("Please enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter your studentID");
            string studentID = Console.ReadLine();

            Console.WriteLine("Please enter your year of birth");
            string yob = Console.ReadLine();

            Console.WriteLine("What year is it?");
            string currentyear = Console.ReadLine();

            int num1 = int.Parse(currentyear);

            int num2 = int.Parse(yob);

            int age = num1 - num2;

            string message = "Hello " + firstname + " " + surname + "!  " + age.ToString() + " " + studentID;
            
            Console.WriteLine(message);
            
            Console.ReadKey();
        }
    }
}
