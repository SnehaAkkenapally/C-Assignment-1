namespace ConsoleApp2;

public class Fizz
{
    public int ab;

    public Fizz(int a)
    {
        ab = a;
    }
    public Fizz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("fizzbuzz");
            else if (i % 3 == 0)
                Console.WriteLine("fizz");
            else if (i % 5 == 0)
                Console.WriteLine("buzz");
            else
                Console.WriteLine(i);
        }
    }
}




/// <summary>
/// ////////////////
/// </summary>


    public class DaysOldCalculator
    {
        public void DisplayDaysOld()
        {
            // Define a birth date
            DateTime birthDate = new DateTime(1990, 1, 1); // Change this date as needed

            // Calculate age in days
            TimeSpan age = DateTime.Now - birthDate;
            int daysOld = age.Days;

            // Calculate days until the next 10,000-day anniversary
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);

            // Output the results
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10,000-day anniversary will be on: {nextAnniversary.ToShortDateString()}");
        }
    }

///
///

class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the class
            Greeting greeter = new Greeting();
            // Call the method to display the greeting
            greeter.DisplayGreeting();
        }
    }

    public class Greeting
    {
        public void DisplayGreeting()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Define greeting based on the time of day
            if (currentTime.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (currentTime.Hour >= 12 && currentTime.Hour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (currentTime.Hour >= 17 && currentTime.Hour < 21)
            {
                Console.WriteLine("Good Evening");
            }

            if (currentTime.Hour >= 21)
            {
                Console.WriteLine("Good Night");
            }
        }
    }


////


    class Increment
    {
        public  Increment()
        {
            // Outer loop for counting by different increments
            for (int increment = 1; increment <= 4; increment++)
            {
                // Inner loop for counting from 0 to 24 with specified increment
                for (int i = 0; i <= 24; i += increment)
                {
                    // Print the current value followed by a comma
                    Console.Write(i);

                    // Print a comma after each number except the last one
                    if (i + increment <= 24)
                    {
                        Console.Write(",");
                    }
                }

                // Move to the next line after completing the inner loop
                Console.WriteLine();
            }
        }
    }










