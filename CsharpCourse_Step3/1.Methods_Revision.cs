using System;

namespace CsharpCourse_Step3
{
    internal class Program
    {

        static string[] ProcessArray(int[] numbers)
        {
            string[] result = new string[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2 == 0 )
                {
                    result[i] = $"{numbers[i]} is Even";
                }
                else
                {
                    result[i] = $"{numbers[i]} is Odd";
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] numbers = {10,15,20,25,30,35};

            string[] output  = ProcessArray(numbers);

            foreach(string res in output)
            {
                Console.WriteLine(res);
            }
        }
    }
}
