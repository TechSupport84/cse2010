using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        int smallestPositive = int.MaxValue;
        
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Loop();

        static void Loop()
        {
            Console.WriteLine("------0--------------Loop---------o-------------");
        string response;
          
        do {
            
                Console.WriteLine("Do you  want to continue  ? ");
                 response  = Console.ReadLine();

            }
            while(response == "Yes");

        for(int i = 0 ;i<10; i++)
        {
            Console.WriteLine(i);
        }
        Random  RandomGenerator = new Random();
        int number  = RandomGenerator.Next(1, 11);

        Console.WriteLine(number);


        List<string>words = new List<string>();

        words.Add("Book ");
        words.Add("Phone");
        words.Add("Python");

        Console.WriteLine(words.Count);
     
       
       foreach(string  names  in  words)
       {
            Console.WriteLine(names);
       }

for(int i=0; i <words.Count; i++)
{
   Console.WriteLine(words[i]);
}
        }
    }

}

