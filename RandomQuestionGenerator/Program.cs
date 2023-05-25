namespace RandomQuestionGenerator;

public static class Program
{
    public static void PrintBeginning()
    {
        Console.WriteLine("Welcome! Please choose one of the following question categories to continue!\n" +
                          "A. All\n" +
                          "B. SQL Question\n" +
                          "C. C# & .NET Question\n" +
                          "D. Web Question");
        Console.WriteLine("Type 'quit' if you wish to exit");
    }
    public static void Main(string[] args)
    {
        var questions = new QuestionStorage();
        var generator = new QuestionGenerator(questions);
        var userInput = string.Empty;

        while (userInput != "quit")
        {
            PrintBeginning();
            userInput = Console.ReadLine()?.ToLower();
            switch (userInput)
            {
                case "a":
                    Console.Clear();
                    Console.WriteLine(generator.GetRandomQuestionFromAll());
                    Console.WriteLine("Press ENTER to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "b":
                    Console.Clear();
                    Console.WriteLine(generator.GetRandomSql());
                    Console.WriteLine("Press ENTER to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine(generator.GetRandomDotNet());
                    Console.WriteLine("Press ENTER to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine(generator.GetRandomWeb());
                    Console.WriteLine("Press ENTER to return to the main menu.");
                    Console.ReadLine();
                    break;
                case "quit":
                    return;
                default:
                    Console.WriteLine("Please enter a valid option!");
                    break;
            }
        }
    }
}