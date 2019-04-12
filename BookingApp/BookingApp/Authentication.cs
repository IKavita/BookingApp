using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp
{
    class Authentication
    {
        public User GetLogin()
        {
            Console.WriteLine("\n------------------------LOGIN-------------------------\n");
            Console.WriteLine("Welcome to The Bucks Centre for the Performing Arts ticket booking system");
            Console.WriteLine("Please Log In");
            Console.WriteLine("");

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            while (username.Length > 12)
            {
                Console.WriteLine("Your username should be 12 characters or less. Please try again:");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            while (password.Length > 8)
            {
                Console.WriteLine("Your password should be less than 8 characters long. Please try again:");
                password = Console.ReadLine();
            }


            if (username == "agent" || username == "admin")
            {
                return new Agent
                {
                    UserName = username,
                    Password = password
                };
            }
            else
            {
                return new Customer
                {
                    UserName = username,
                    Password = password
                };

            }
            
        }

    }
}
