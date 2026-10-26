using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class WorkItems
    {
        public static void PreapreWordDocumentation()
        {

            Thread.Sleep(2000);

            Console.WriteLine($"Prepare Word Documentation");
        }

        public static void PreaprePPTsPresantation()
        {

            Thread.Sleep(2000);

            Console.WriteLine($"Prepare PPT Documentation");
        }

        public static void PreapreNotes()
        {
            ;
            Thread.Sleep(5000);

            Console.WriteLine($"Prepare Notes");
        }
    }

    class Trainer
    {
        public static void LetsStart()
        {

            Task.Run(() => { WorkItems.PreapreWordDocumentation(); });
            Task.Run(() => { WorkItems.PreaprePPTsPresantation(); });
            Task.Run(() => { WorkItems.PreapreNotes(); });
        }

        public static void EmergencyWork()
        {
            string trainerStatus = "Trainer is going outside for emergency tasks";
            Console.WriteLine($"Trainer Status : {trainerStatus}");
        }
    }

    class Program
    {
        static void Main()
        {
            Trainer.LetsStart();
            Trainer.EmergencyWork();
            Console.ReadLine();
        }
    }
}