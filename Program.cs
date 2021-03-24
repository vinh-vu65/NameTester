using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        MenuOption userSelection;
        do
        {
        userSelection = ReadUserOption();
        switch(userSelection)
            {
            case MenuOption.TestName:
            Console.WriteLine("You have selected Test Name.");
            TestName();
            break;

            case MenuOption.GuessThatNumber:
            Console.WriteLine("You have selected Guess That Number.");
            RunGuessThatNumber();
            break;

            case MenuOption.Quit:
            Console.WriteLine("You have selected Quit.");
            break;
            }
        } while (userSelection != MenuOption.Quit);
    }

    private static MenuOption ReadUserOption()
        {
            int option;

            Console.WriteLine("--Welcome to the program--");
            Console.WriteLine("Select 1 to run Test Name");
            Console.WriteLine("Select 2 to run Guess That Number");
            Console.WriteLine("Select 3 to Quit");

            do
            {
                Console.Write("Please choose an option [1-3]:");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option > 3 || option < 1);
            return (MenuOption)(option - 1);
        }

    static void TestName()
    {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");  
        if (name.ToLower() == "vinh")
        {
            Console.WriteLine("Hello you coding God");
        }
        else if (name.ToLower() == "kim")
        {
            Console.WriteLine("Give the controls back to Vinh xD");
        }
        else if (name.ToLower() == "shaun")
        {
            Console.WriteLine("Ain't this something");
        }
        else
        {
            Console.WriteLine("Who even are you??");
        }
    }
    static void RunGuessThatNumber()
    {
        int target;
        int min = 1;
        int max = 100;
        int guess;

        target = new Random().Next(100) + 1;
        guess = ReadGuess(min, max);  
        while (guess != target)
        {
            
            if (guess < target)
            {
                Console.WriteLine("Too low! Guess a higher number");
                min = guess;
                
            }
            else if (guess > target)
            {
                Console.WriteLine("Too high! Guess a lower number");
                max = guess;
                
            }
            guess = ReadGuess(min, max);
        } 
          if (guess == target)
            {
                Console.WriteLine("You got the right number!");
                
            }
    }
    private static int ReadGuess(int min, int max)
    {
        int guess;
        do
        {
            Console.WriteLine($"Enter your guess between {min} and {max}");
            guess = Convert.ToInt32(Console.ReadLine());
        } while (guess < min || guess > max);
        
        return guess;
    }
}

public enum MenuOption
{
    TestName,
    GuessThatNumber,
    Quit
}