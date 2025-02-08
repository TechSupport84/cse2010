public class ListingActivity :Activity
{
    private int _count;
    private List<string>_prompts = new();

    public ListingActivity(string name , string description, int  duration, int count) :base(name,description,duration)
    {
      _count = 0;
      _prompts.Add("Who are people that you appreciate?");
      _prompts.Add("What are personal strengths of yours?");
      _prompts.Add("Who are people that you have helped this week?");
      _prompts.Add("When have you felt the Holy Ghost this month?");
      _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
        Console.WriteLine("Welcome to reflecting  Activity");
        GetRandomPrompt();
        GetListFromUser();
    }
    public void GetRandomPrompt()
    {
       Random random = new Random();
       random.Next(_prompts.Count);
       
       
    }
    public List<string> GetListFromUser()
    {
       List<string> responses = new ();

       return responses;
    }
}