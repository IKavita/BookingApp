using System;

namespace BookingApp
{
    class Customer : User
    {
        public override void GetAllBookings(Show show, string ticketAmount, string cost)
        {
            base.GetAllBookings(show, ticketAmount, cost);
            Console.WriteLine("");
            Console.WriteLine("Customer Bookings:");
            Console.WriteLine("Show Name: " + show.ShowName);
            Console.WriteLine("Show Date: " + show.ShowDate);
            Console.WriteLine("Show Time: " + show.ShowTime);
            Console.WriteLine("Ticket Amount: " + ticketAmount);
            Console.WriteLine("Price Paid: " + cost);
        }
    }
}
