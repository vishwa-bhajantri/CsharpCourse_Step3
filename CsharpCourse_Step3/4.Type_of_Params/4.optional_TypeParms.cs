using System;

namespace OptionalParameter_Example
{
    class NotificationService
    {
        static void Main()
        {
            SendNotofication("KETA", "High");
            BookTicket("Ravi");
            BookTicket("Ram", "Window");


        }

        static void SendNotofication(string userName, string priority = "Normal")
        {
            
            Console.WriteLine($"User Name is {userName}");
            Console.WriteLine($"Priority is : {priority}");
        }

        static void BookTicket(string PassengerName, string SeatType = "Regular", bool isMealRequired = true)
        {
            Console.WriteLine($"Passenger Name {PassengerName}");
            Console.WriteLine($"Seat Type : {SeatType}");
            Console.WriteLine($"Meal Required {isMealRequired}");
        }
    }
}