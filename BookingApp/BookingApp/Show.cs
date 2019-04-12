using System;

namespace BookingApp
{
    class Show
    {
        public string ShowName { get; set; }
        public string ShowDate { get; set; }
        public string ShowTime { get; set; }

        public void SelectShow(string showName, string showDate)
        {
            string show1 = "Woman In Black ";
            string show2 = "Pretty Woman ";
            string show3 = "Avengers - Infinity War ";
            string show4 = "Ready Player One ";

            string date1 = "20-4-19";
            string date2 = "25-4-19";
            string date3 = "10-5-19";
            string date4 = "15-5-19";

            Console.WriteLine("\n-----------------------Please select an upcoming show-----------------------------\n:");
            Console.WriteLine("1. " + show1 + "-" + date1);
            Console.WriteLine("2. " + show2 + "-" + date2);
            Console.WriteLine("3. " + show3 + "-" + date3);
            Console.WriteLine("4. " + show4 + "-" + date4);
            char showOpt = Convert.ToChar(Console.ReadLine());

            while (showOpt != '1' && showOpt != '2' && showOpt != '3' && showOpt != '4')
            {
                Console.WriteLine("Please enter a valid option number");
                showOpt = Convert.ToChar(Console.ReadLine());
            }

            switch (showOpt)
            {
                case '1':
                    showName = show1;
                    showDate = date1;
                    break;
                case '2':
                    showName = show2;
                    showDate = date2;
                    break;
                case '3':
                    showName = show3;
                    showDate = date3;
                    break;
                case '4':
                    showName = show4;
                    showDate = date4;
                    break;
            }

            ShowName = showName;
            ShowDate = showDate;
        }

        public void SelectShowTime(string showTime)
        {
            string time1 = "3pm";
            string time2 = "7pm";

            Console.WriteLine("\n-----------------------Please select a showing time-----------------------------\n:");
            Console.WriteLine("1. " + time1);
            Console.WriteLine("2. " + time2);
            char timeOpt = Convert.ToChar(Console.ReadLine());

            while (timeOpt != '1' && timeOpt != '2')
            {
                Console.WriteLine("Please enter a valid option number");
                timeOpt = Convert.ToChar(Console.ReadLine());
            }

            switch (timeOpt)
            {
                case '1':
                    showTime = time1;
                    break;
                case '2':
                    showTime = time2;
                    break;
            }

            ShowTime = showTime;
        }
    }
}