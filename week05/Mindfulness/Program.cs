using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity ");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        Console.WriteLine("Select a  choice from the menu: ");


        string  count = Console.ReadLine();
        int validCount = int.Parse(count);

        BreathActivity breathActivity =  new BreathActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
         string name  = Console.ReadLine();
        string  description = Console.ReadLine();
        string  duration = Console.ReadLine();
        int validDuration = int.Parse(duration);
        ListingActivity listingActivity = new ListingActivity(name, description, validDuration, validCount);
        Activity activity = new Activity(name, description, validDuration);

        while(true)
        {
            string choice = Console.ReadLine();
            int userChoice = int.Parse(choice);
            if( userChoice == 1)
            {
              breathActivity.Run();
              activity.ShowSpinner(validCount);
              reflectingActivity.DisplayPrompt();
              //
            }
            else if ( userChoice == 2)
            {
              listingActivity.DisplayStartingMessage();
             activity.ShowSpinner(validCount);
              reflectingActivity.DisplayPrompt();
              listingActivity.DisplayEndingMessage();
            }
            else if( userChoice == 3)
            {
              listingActivity.DisplayStartingMessage();
              listingActivity.GetListFromUser().Add(name);
              listingActivity.GetListFromUser().Add(description);
              listingActivity.GetListFromUser().Add(duration);
              
              listingActivity.DisplayStartingMessage();
            }
            else if ( userChoice == 4)
            {
                return;
            }
        }
    }
}