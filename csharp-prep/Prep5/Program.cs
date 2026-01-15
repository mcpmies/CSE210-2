using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:  ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:  ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born:  ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }

    static void DisplayResult(string userName, int square, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
        Console.WriteLine($"{userName}, you will turn {2026 - birthYear} years old this year.");
    }
}