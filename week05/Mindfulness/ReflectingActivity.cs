public class ReflectingActivity 
{
    private  List<string> _prompts = new();
    private List<string> _questions = new();

    public ReflectingActivity() 
    {
      _questions.Add("Who are people that you appreciate?");
      _questions.Add("What are personal strengths of yours? ");
      _questions.Add("Who are people that you have helped this week?");
      _questions.Add("When have you felt the Holy Ghost this month?");
      _questions.Add("Who are some of your personal heroes?");


     _prompts.Add("Think of a time when you stood up for someone else.");
     _prompts.Add("Think of a time when you did something really difficult.");
     _prompts.Add("Think of a time when you helped someone in need.");
     _prompts.Add("Think of a time when you did something truly selfless");
    }
    public void Run()
    {
    Console.WriteLine("Consider the following  prompts: ");
     Console.WriteLine("his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
     DisplayPrompt();
     DisplayQuestions();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return  _prompts[random.Next(_questions.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random ();

        return _questions[random.Next(_questions.Count)];
    }
    public void DisplayPrompt()
    {
         GetRandomPrompt();
    }
    public void DisplayQuestions()
    {
        GetRandomQuestion();
    }
}