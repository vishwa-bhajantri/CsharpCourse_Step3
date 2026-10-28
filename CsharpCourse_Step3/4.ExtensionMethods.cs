using System;

namespace PhoneSystem
{
    public class Smartphone
    { 
        public string Brand { get; set; }
        public void MakeCall(string number)
        {
            Console.WriteLine($"Calling {number} from {Brand} smartphone");
        }
    }

    public static class SmartphoneExtensions
    {
        public static void TrackFitness(this Smartphone phone)
        {
            Console.WriteLine($"The {phone.Brand} smartphone is tracking fitness now");
        }

        public static void PlayGame(this Smartphone phone, string gameName)
        {
            Console.WriteLine($"Playing {gameName} Game on the {phone.Brand} smartphone");
        }
    }

    public class program
    {
        public static void Main()
        {
            Smartphone smartphone = new Smartphone { Brand = "Pixel" };
            smartphone.MakeCall("1234567890");

            smartphone.TrackFitness();
            smartphone.PlayGame("F1");
        }
    }
}