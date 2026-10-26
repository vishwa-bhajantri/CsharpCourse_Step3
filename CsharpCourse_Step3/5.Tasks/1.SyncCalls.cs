using System;
using System.Diagnostics;
using System.Threading;

namespace SyncCalls
{
    class WorkItems
    {
        public static void PreapreWordDocumentation()
        {
            Stopwatch watch = Stopwatch.StartNew();
            Thread.Sleep(2000);
            watch.Stop();
            Console.WriteLine($"Prepare Word Documentation {watch.Elapsed.TotalSeconds}");
        }

        public static void PreaprePPTsPresantation()
        {
            Stopwatch watch = Stopwatch.StartNew();
            Thread.Sleep(2000);
            watch.Stop();
            Console.WriteLine($"Prepare PPT Documentation {watch.Elapsed.TotalSeconds}");
        }

        public static void PreapreNotes()
        {
            Stopwatch watch = Stopwatch.StartNew();
            Thread.Sleep(5000);
            watch.Stop();
            Console.WriteLine($"Prepare Notes {watch.Elapsed.TotalSeconds}");
        }
    }

    class Trainer
    {
        public static void Works()
        {
            Console.WriteLine($"Sequential Works Step by Step");

            Stopwatch watch = Stopwatch.StartNew();

            WorkItems.PreapreWordDocumentation();
            WorkItems.PreaprePPTsPresantation();
            WorkItems.PreapreNotes();
            watch.Stop();

            Console.WriteLine($"All Tasks are Completed {watch.Elapsed.TotalSeconds}");
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
            Trainer.Works();
            Trainer.EmergencyWork();
        }
    }
}