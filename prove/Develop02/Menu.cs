class Menu
{
    private string _instructions = "Please select one of the following choices:";
    private List<string> _menuItems = new List<string>() { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };
    private string _choiceQuestion = "What would you like to do?";

    public void DisplayMenu()
    {
        Console.WriteLine(_instructions);
        foreach (string item in _menuItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(_choiceQuestion);
    }

    public void Animation()
    {
        int duration = 3;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write(".");
            Thread.Sleep(sleepTime);
            Console.Write(" .");
            Thread.Sleep(sleepTime);
            Console.Write(" .");
            Thread.Sleep(sleepTime);
            Console.Clear();
            Thread.Sleep(sleepTime);
        }
    }

    public void MenuSelect()
    {
        bool menuRunning = true;
        Journal journal = new Journal();
        Questions question = new Questions();

        while (menuRunning)
        {
            Console.Clear();
            DisplayMenu();
            string menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1": // Write
                    string prompt = question.SelectQuestion();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.NewEntry(new Entry(prompt, response));
                    break;
                case "2": // Display
                    Animation();
                    journal.DisplayJournal();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3": //Load
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadJournal(loadFile);
                    break;
                case "4": // Save
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournal(saveFile);
                    break;
                case "5": //Quit
                    menuRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

}