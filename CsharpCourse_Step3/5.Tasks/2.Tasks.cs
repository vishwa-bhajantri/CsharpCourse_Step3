using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class WorkItems
    {
        public static Task<string> PreapreWordDocumentation()
        {
            Task<string> task = Task.Run(() =>
            {

                Thread.Sleep(2000);

                return $"Prepare Word Documentation";
            });
            return task;
        }

        public static Task<string> PreaprePPTsPresantation()
        {
            Task<string> task = Task.Run(() =>
            {

                Thread.Sleep(2000);

                return $"Prepare PPT Documentation";

            });
            return task;
        }

        public static Task<string> PreapreNotes()
        {
            Task<string> task = Task.Run(() =>
            {

                Thread.Sleep(5000);

                return $"Prepare Notes";

            });
            return task;
        }
    }

    class Trainer
    {
        public static void LetsStart()
        {
            Stopwatch watch = Stopwatch.StartNew();

            Task<string> task1 = WorkItems.PreapreWordDocumentation();
            //task1.Wait();
            //string result = task1.Result;
            //Console.WriteLine(result);

            Task<string> task2 = WorkItems.PreaprePPTsPresantation();
            //task2.Wait();
            //string result2 = task2.Result;
            //Console.WriteLine(result2);

            Task<string> task3 = WorkItems.PreapreNotes();
            //task3.Wait();
            //string result3 = task3.Result;
            //Console.WriteLine(result3);

            Task.WhenAll(task1, task2, task3).Wait();
            string result1 = task1.Result;
            string result2 = task2.Result;
            string result3 = task3.Result;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            watch.Stop();

            Console.WriteLine($"All Works are Completed by The Trainer in {watch.Elapsed.TotalSeconds} seconds");
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