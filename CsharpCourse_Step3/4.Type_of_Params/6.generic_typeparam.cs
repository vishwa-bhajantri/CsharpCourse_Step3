using System;

namespace GenericParameter_Example
{
    class Logger
    {
        public void Log<T>(T data)
        {
            Console.WriteLine(data);   
        }
    }

    class Program
    {
        static void Main()
        {
            Logger logger = new Logger();
            logger.Log<string>("User Registered");
            logger.Log<int>(252);
            logger.Log<DateTime>(DateTime.Now);
            logger.Log<bool>(false);
        }
    }
}