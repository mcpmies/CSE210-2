using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage: ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Keep trying!");
        }

        Console.WriteLine($"Your grade is a(n) {letterGrade}");
    }
}