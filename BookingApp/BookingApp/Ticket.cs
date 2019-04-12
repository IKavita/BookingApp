using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp
{
    class Ticket
    {
        public int MaxTicketsPerCustomer { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }

        public int GetTicketAmount(User user)
        {
            if (user.UserName == "admin" || user.UserName == "agent")
            {
                MaxTicketsPerCustomer = 5;
                Price = 18;
            }
            else
            {
                MaxTicketsPerCustomer = 3;
                Price = 15;
            }

            Console.WriteLine("The price is £" + Price + " for a ticket. How many tickets would you like?");
            int ticketAmount = Convert.ToInt32(Console.ReadLine());

            while (ticketAmount == 0)
            {
                Console.WriteLine("Please Enter a valid amount of tickets:");
                ticketAmount = Convert.ToInt32(Console.ReadLine());
            }

            while (ticketAmount > MaxTicketsPerCustomer)
            {
                Console.WriteLine("The max amount tickets you are allowed to book is " + MaxTicketsPerCustomer);
                Console.WriteLine("Please enter a valid amount:");
                ticketAmount = Convert.ToInt32(Console.ReadLine());
            }

            return ticketAmount;
        }

        public int CalculateTicketPrice(int ticketAmount)
        {
            int cost = ticketAmount * Price;

            Console.WriteLine("You have chosen " + ticketAmount + " tickets.");
            Console.WriteLine("The price will be £" + cost);

            Cost = cost;

            return Cost;
        }

        public void Pay()
        {
            Console.WriteLine("Please enter your card details to make the payment of £" + Cost);
            Console.ReadLine();
            Console.WriteLine("Success - Your Payment has been made!");
            Console.WriteLine("Thank you for booking with us, please come back soon.");
        }
    }
}
