using System ; 
class Program
{
    static void Main(string[]args)
    {
        Journal journal = new();
        string fileName  = "journal.txt";

        while (true)
        {
            Console.WriteLine("1. Write new Entry");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save"); 
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Enter Selection:  ");
            string userInput  = Console.ReadLine();

            Console.WriteLine($"User selection {userInput}");

            if(userInput == "1")
            {
               Console.WriteLine ("Write new Entry ");
               journal.AddEntry();
            }
            else if(userInput == "2")
            {
               Console.WriteLine("Display Journal ");
               journal.Display();
            }else if (userInput == "3")
            {
               Console.WriteLine("Save  Journal ");
               journal.SaveToFile(fileName);

            }else if (userInput == "4")
            {
               Console.WriteLine("Load Jouranl ");
               journal.LoadFromFile(fileName);
            }else if (userInput == "5")
            {
               return ;
            }else
            {
                Console.WriteLine("Please try again ");
            }
        }
    }
}