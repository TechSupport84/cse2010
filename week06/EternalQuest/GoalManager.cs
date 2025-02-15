
using System.Security.Cryptography;
using GoalTrackingSystem;

class   GoalManager
{
    private static  List<Goal> _goals = new ();
    private int  _score ;


    public GoalManager(int score)
    {
      _score = score;
    }

    public void Start()
    {
      Console.WriteLine("The types  of Goals are : ");

    }
   
   public void DisplayPlayerInfo()
   {
       Console.WriteLine();
   }

   public void ListGoalNames()
   {

   }
   public void  ListGoalDetails()
   {
  
        foreach(var goal in  _goals )
        {
  
          int index = 0;
          if(goal.IsComplete())
          {
          Console.WriteLine($"{index}.[x] {goal.GetDetailsString}");
          index ++;
          }
          else{
          Console.WriteLine($"{index}.[] {goal.GetDetailsString}");
          index ++;
          }
        
        }
   }
   public  static  void  CreateGoal()
   {
      Console.WriteLine("1. Simple Goal");
      Console.WriteLine("2. Eternal Goal");
      Console.WriteLine("3. Checklist Goal ");
      Console.WriteLine("What  type  of Goal  would  you  like to create ? ");
      string  goalsOPtion = Console.ReadLine();
      if (goalsOPtion == "1")
      {
         Console.WriteLine("What is the  name of your goal ?");
         string name = Console.ReadLine();
         Console.WriteLine("What is the  short description  of  it ?");
         string description = Console.ReadLine();
         Console.WriteLine("What is the  amount of points associated with  this  goal ?");
         int points = int.Parse(Console.ReadLine());


         Goal newGoal = new SimpleGoal(name,description, points ,false);
         _goals.Add(newGoal);
         Console.WriteLine($"You have {_goals} points.");
       }
      
      else if (goalsOPtion == "2")
      {

         Goal newEternalGoal = new  EternalGoal("jeanc","jeancy",24);

      }
      else if (goalsOPtion == "3")
      {
      Console.WriteLine("What is the  name of your goal? ");
      string name = Console.ReadLine();
      Console.WriteLine("What is the  short description  of  it ?");
      string description = Console.ReadLine();
      Console.WriteLine("What is the  amount of points associated with  this  goal ?");
      int points = int.Parse(Console.ReadLine());
      Console.WriteLine("How many times does this  goal need to be  accomplished for a bonus?");
      int amountCompleted = int.Parse(Console.ReadLine());
      Console.WriteLine("What is  the bonus for accomplishing it that  many times ?");
      int bonus = int.Parse(Console.ReadLine());
      Goal newCheckListGoal = new ChecklistGoal(name, description, points,amountCompleted,bonus);
      _goals.Add(newCheckListGoal);


      }

   }
   public  void RecordEvent()
   {
        Console.WriteLine("Menu Options :");

        while (true)
        {
          
        Console.WriteLine("1. Give a talk ");
        Console.WriteLine("2. Study the scriptures ");
        Console.WriteLine("3. Attend the temple");
        Console.WriteLine("Which goal did  you accomplish ?");

        string recordOptions = Console.ReadLine();
        if(recordOptions == "1")
        {


        }
        else if (recordOptions == "2")
        {
          int  points = +50;
          Console.WriteLine($"Congratelations !You have earned {points} ");

        }
        else if (recordOptions == "3")
        {

        }

        }

   }

  public void  SaveGoals()
  {
     Console.WriteLine("What is the filename for the goal file ? ");
     string filename =  Console.ReadLine();
     using (StreamWriter output  = new StreamWriter(filename))
     {

      output.WriteLine(_score);
      foreach (var goal in _goals)
      {
         output.WriteLine(goal.GetStringRepresentation());
      }
   
     }

     
  }
  public void LoadGoals()
  {
     Console.WriteLine("What is the  file name ? ");
     string filename = Console.ReadLine();
     if(!File.Exists(filename))
     {
        Console.WriteLine("No file exists ");
     }{

     string[] goalsSaved = System.IO.File.ReadAllLines(filename);

     foreach(string line in goalsSaved)
     {
       string [] parts = line.Split(",");

       string simpleGoals = parts[0];
       string eternalGoal  = parts[1];
       string checklistGoal = parts[2];
       Console.WriteLine($"Simple Goal :{simpleGoals}");
       Console.WriteLine($"Eternal Goal: {eternalGoal}");
       Console.WriteLine($"CheckListGoal: {checklistGoal}");
     }
     }

    
     
  }
}