using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 0 points.");
       int score = +50;

        GoalManager goalManager = new GoalManager(score);
 
    
        while(true)
        {
            Console.WriteLine("Menu Options :");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string  options =  Console.ReadLine();
            int validOption = int.Parse(options);
            if (validOption == 1)
            {
                goalManager.Start();
                GoalManager.CreateGoal();
                goalManager.DisplayPlayerInfo();

            }
            else if (validOption == 2)
            {
                 goalManager.ListGoalDetails();
            }
            else if (validOption == 3)
            { 
                goalManager.SaveGoals();

            }
            else if (validOption ==4)
            {
              goalManager.LoadGoals();
            } 
            else if (validOption == 5)
            {
              goalManager.RecordEvent();
            }
            else if (validOption ==6)
            {
                return;
            }
        }


        
    }

}


