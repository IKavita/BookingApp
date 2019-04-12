using System;

namespace BookingApp
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetProfileInfo(string name, string address)
        {
            Console.WriteLine("Please enter your profile information to create a new account.");
            Console.WriteLine("Name:");
            name = Console.ReadLine();

            while (name.Length < 2)
            {
                Console.WriteLine("Your name should be longer than 1 character");
                name = Console.ReadLine();
            }

            Console.WriteLine("Address:");
            address = Console.ReadLine();

            Name = name;
            Address = address;
        }

        public void ViewProfileDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
        }

        public virtual void GetAllBookings(Show show, string ticketAmount, string cost)
        {
            Console.WriteLine("Bookings are shown below:");
        }
    }
}
