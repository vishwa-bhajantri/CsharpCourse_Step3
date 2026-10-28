using System;

namespace ExtensionMethods
{

    public static class StringExtensions
    {
        public static int WordCount(this string input)
        {
            string[] words = input.Split(' ');
            int length = words.Length;
            return length;
        }
    }

    public class program
    {
        public static void Main()
        {
            string sentence = "Hello, Extension Methods are Powerfull";
            Console.WriteLine(sentence.WordCount());
        }
    }
}