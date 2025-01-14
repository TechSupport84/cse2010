using System;
    class Program
    {
        static void Main (string[] args)
        {
             Console.Write ("Are you  a  byu  stundent  ?(Yes/No) ");
             string responseUser = Console.ReadLine();

             if(responseUser == "Yes")
             {
                Console.WriteLine("What is  your  name ?  ");
                string name =  Console.ReadLine();
                if(name == "")
                {
                    Console.WriteLine("Please write down  your name  to  continue  .");
                    return; 
                }
                else{
                    Console.WriteLine($"Hello ,  {name} ,  Welcome !");

                }
             }
             else if (responseUser == "No")
             {
                Console.WriteLine("Application ");
                Console.WriteLine("Would  like to Register for the nex Semester  ?(Yes/No) ");
                string  optionUser = Console.ReadLine();
                if( optionUser == "Yes")
                {
                    string name;
                    string email; 
                    int age ; 
                    int  tel;
                    Console.WriteLine("Fill out these fields ASAP ");
                    Console.WriteLine("What is your name ?");
                    string nameEntry =  Console.ReadLine();

                    Console.WriteLine("What is your email  address ? ");
                    string  emailEntry =  Console.ReadLine();

                    Console.WriteLine("How old are you ?  ");
                    string ageEntry = Console.ReadLine();

                    Console.WriteLine("What is  your Phone  number ?");
                    string  telEntry = Console.ReadLine();

                    if(nameEntry == "" ||emailEntry =="" || ageEntry ==" " || telEntry =="")
                    {
                        Console.WriteLine("All Fields required * ");
                        return;
                    }
                    else
                        {
                            name  = nameEntry;
                            email = emailEntry;
                            age = int.Parse(ageEntry);
                            tel = int.Parse(telEntry);
            
                            Console.WriteLine($"Your  name  : is {name } - email ({email}) your age {age } and  phone Number: {tel}");
                            
                        }

                }
                else if (optionUser == "No")
                {
                    Console.WriteLine("Would you  like to continue  later ?  ");
                    if (optionUser == "Yes")
                    {
                        Console.WriteLine("Congrats !  see you  again .");

                    }
                    else {
                        Console.WriteLine("Bye e ! ");
                    }
                }
                 else{
                    Console.WriteLine ("See you  man ");
                 } 



              
             }
        }
    }