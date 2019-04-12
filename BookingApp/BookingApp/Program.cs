using System;

namespace BookingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //variables
            string name = "";
            string address = "";
            string showName = "";
            string showDate = "";
            string showTime = "";
            string ticketAm = "";
            string cost = "";

            //objects
            Authentication auth = new Authentication();
            Show show = new Show();
            Ticket ticket = new Ticket();

            //get customer information
            User user = auth.GetLogin();
            user.GetProfileInfo(name, address);

            //display main menu and user choose option
            Console.WriteLine("Please enter an option number from the menu below:");
            Console.WriteLine("");
            Console.WriteLine("\n------------------MENU------------------\n");
            Console.WriteLine("1. View and Book Upcoming shows");
            Console.WriteLine("2. View Profile Details");
            Console.WriteLine("3. View Bookings");
            Console.WriteLine("4. Log Out and Exit");
            char menuOpt = Convert.ToChar(Console.ReadLine());

            while (menuOpt != '1' && menuOpt != '2' && menuOpt != '3' && menuOpt != '4')
            {
                Console.WriteLine("Please enter a valid option number");
                menuOpt = Convert.ToChar(Console.ReadLine());
            }


            switch (menuOpt)
            {
                case '1':
                    while (true)
                    {
                        show.SelectShow(showName, showDate);
                        show.SelectShowTime(showTime);
                        Console.WriteLine("Are you happy with your selection? (Y = Yes / N = No)");
                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            break;
                        }
                    }

                    int ticketAmount = ticket.GetTicketAmount(user);
                    int costPaid = ticket.CalculateTicketPrice(ticketAmount);
                    ticket.Pay();

                    ticketAm = ticketAmount.ToString();
                    cost = costPaid.ToString();

                    Console.WriteLine("");
                    Console.WriteLine("Would you like to view your bookings? (Y = Yes / N = No)");
                    string answer2 = Console.ReadLine().ToUpper();


                    if (answer2 == "Y")
                    {
                        user.GetAllBookings(show, ticketAm, cost);
                        Console.WriteLine("See you next time. Press any character to exit");
                    }
                    else
                    {
                        Console.WriteLine("See you next time. Press any character to exit");
                    }

                    break;
                case '2':
                    user.ViewProfileDetails();
                    Console.WriteLine("See you next time. Press any character to exit");
                    break;
                case '3':
                    user.GetAllBookings(show, ticketAm, cost);
                    break;
                case '4':
                    Console.WriteLine("LOGGED OUT - Press any character to exit");
                    break;
            }

            Console.ReadKey();
        }
    }
}
