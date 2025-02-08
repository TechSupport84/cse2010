public class Activity
{
    private string _name ="";
    private string _description ="";
    private int  _duration ;

    public Activity(string name ,string description, int duration)
    {
      _name = name ;
      _description = description;
      _duration = duration;

    }

    public void  DisplayStartingMessage()
    {
       Console.WriteLine("Welcome to the Breathing Activity");
       Console.WriteLine("This activity will  help you  relax by  walking your through breathing in and  slowly. Clear your mind and focus on your breath.");

    
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {
      int i = 0;
      List<string>_spinner = new List<string>();
      _spinner.Add("/");
      _spinner.Add("-");
      _spinner.Add("\\");
      _spinner.Add("/");
      _spinner.Add("|");
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(seconds);

      
      while(DateTime.Now <endTime)
      {
        string sp = _spinner[i];
        Console.Write(sp);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;

       if(i >= _spinner.Count)
          {
           i = 0;
          }
          for(int k = 0; k < 5; k++ )
      {
        Console.Write($"Breathe in ...");
        Console.Write(k);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
    for(int j = 0; j < 5; j++ )
      {
        Console.Write($"Breathe out ...");
        Console.Write(j);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        

      }

         Console.Write("Well done !");
     Console.WriteLine($"Well don  you  have completed  another {seconds} of the breathing activiy");
       string sp1 = _spinner[i];
        Console.Write(sp1);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;
        if(i >= _spinner.Count)
          {
            i = 0;
         }
  return;

    }
  
      }
     
     
   
    public void ShowCountDown(int  seconds)
    {
       
       for (int  i = 0; i < seconds ; i-- )
       {
        
       }
    }
}