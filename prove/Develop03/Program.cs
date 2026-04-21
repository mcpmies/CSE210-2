using System;

class Program
{
    static void Main(string[] args)
    {
        Reference Isaiah = new Reference("Isaiah", 25, 8);
        Scripture Easter = new Scripture(Isaiah, "He will swallow up death in victory; and the Lord God will wipe away tears from off all faces; and the rebuke of his people shall he take away from off all the earth: for the Lord hath spoken it.");

        
        bool programRunning = true;

        while(programRunning)
        {
           Console.Clear();
           //print out scripture
           Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        }
    }
}