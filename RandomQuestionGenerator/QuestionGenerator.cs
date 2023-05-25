namespace RandomQuestionGenerator;

public class QuestionGenerator
{
    private QuestionStorage Questions { get; set; }
    private readonly Random _r = new Random();
    public QuestionGenerator(QuestionStorage questions)
    {
        Questions = questions;
    }

    public string GetRandomQuestionFromAll()
    {
        var randomCategory = _r.Next(1, 4);
        return randomCategory switch
        {
            1 => GetRandomWeb(),
            2 => GetRandomDotNet(),
            3 => GetRandomSql(),
            _ => throw new IndexOutOfRangeException("The random category chosen does not exist!")
        };
    }

    public string GetRandomSql()
    {
        Console.WriteLine("SQL Question");
        return Questions.SQLQuestions[_r.Next(Questions.SQLQuestions.Length)];
    }
    
    public string GetRandomWeb()
    {
        Console.WriteLine("Web Question");
        return Questions.WebQuestions[_r.Next(Questions.WebQuestions.Length)];
    }
    
    public string GetRandomDotNet()
    {
        Console.WriteLine("C# & .NET Question");
        return Questions.CSharpDotNetQuestions[_r.Next(Questions.CSharpDotNetQuestions.Length)];
    }
}