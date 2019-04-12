using System;

namespace BookingApp
{
    class Agent : User
    {
        public override void GetAllBookings(Show show, string ticketAmount, string cost)
        {
            base.GetAllBookings(show, ticketAmount, cost);
            Console.WriteLine("All Bookings Under Agent:");
            Console.WriteLine("Customer: Kavita");
            Console.WriteLine("Address: Ub2 5jj");
            Console.WriteLine("Show Name: Avengers");
            Console.WriteLine("Show Time: 7pm");
            Console.WriteLine("Ticket Amount: 4");
            Console.WriteLine("Price Paid: £72");
            Console.WriteLine("");
            Console.WriteLine("Latest Booking:");
            Console.WriteLine("Show Name: " + show.ShowName);
            Console.WriteLine("Show Date: " + show.ShowDate);
            Console.WriteLine("Show Time: " + show.ShowTime);
            Console.WriteLine("Ticket Amount: " + ticketAmount);
            Console.WriteLine("Price Paid: " + cost);
        }
    }
}
