using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UltraAuth™ All Rights Reserved 2021.");

            // Change the appearance of console
            Console.Title = "UltraAuth™";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            // Ask for Username
            Console.WriteLine("Username: \n");

            // Password and Username
            String userName = "bye"; // ADD YOUR USERNAME HERE
            String Password = "hi"; // ADD YOUR PASSWORD HERE

            // Returns 0 when the input and username are the same
            int resultUsername = String.Compare(userName, Convert.ToString(Console.ReadLine()));
            
            // Checks if username is valid
            if (resultUsername == 0) { 
                
                Console.WriteLine("Password: \n");

                // Returns 0 when the input and username are the same
                int resultPassword = String.Compare(Password, Convert.ToString(Console.ReadLine()));
                
                // Checks if password is valid
                if(resultPassword == 0) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    Console.WriteLine("Access Granted \n");

                    Console.ForegroundColor = ConsoleColor.White;
                    
                    // Software Details
                    Console.WriteLine("UltraAuth™ All Rights Reserved 2021." + " You may now close this window.");
                    Console.ReadKey();
                } 
            } 
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("Error, That is not a valid Username");
            }
            
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("Access Denied \n");

            Console.ForegroundColor = ConsoleColor.White;

            // Software Details
            Console.WriteLine("UltraAuth™ All Rights Reserved 2021." + " You may now close this window.");

            Console.ReadKey();
        }
    }
}
