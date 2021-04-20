using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static private void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            
            Console.WriteLine("Hi {0}! Where are you from?", person.name);
            person.location = Console.ReadLine();
            
            Console.WriteLine("I have never been to {0}. I bet it is nice. Press any key to continue...", person.location);
            Console.ReadKey();

        }

        static private void ChristmasCountdown(DateTime date) 
        {
            DateTime christmasDate = new DateTime(2021, 12, 25);
            int days = christmasDate.Subtract(date).Days;
            Console.WriteLine("Today's date is: {0}", date.ToString("MM/dd/yyyy"));
            Console.WriteLine("There are {0} days until Christmas!", days);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();
        }
        
    }
}
