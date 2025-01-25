using System;

class Program
{
    static void Main(string[] args)
    {
        string  words1 = "16 ¶ For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string words = "5 ¶ Trust in the Lord with all thine heart; and lean not unto thine own understanding.6 In all thy ways acknowledge him, and he shall direct thy paths.";
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Clear();
        Word word1 = new Word(words1);
        Word word2 = new Word(words);


        while (true)
        {
        Console.WriteLine("Type show to display and  (quit) to exit"); 
        string options =  Console.ReadLine();

        if(options =="show")
        {
           Console.WriteLine(word1.GetDisplayText()); 
           Console.WriteLine(word2.GetDisplayText()); 
           word1.Hide();
           word2.Hide();
        }
        else if(options == "quit")
        {
           return;
        }

    }
    }
}