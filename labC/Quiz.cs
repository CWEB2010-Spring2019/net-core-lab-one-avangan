using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring and array that holds the correct answers. You name the array and add it's datatype. datatype[] arrayName;
            string[] corAns;

            // Initializing the Array to assign how many indexes it will have there are 10 questions we will have 10 correct answers
            string[] corAns = { "A", "A", "B" };



            // declaring an array for end users selection


            // Initializing the Array for 10 Users answers
            string[] UseAns = new string[10];

            int start; ///public variable declaration



            Console.WriteLine("Welcome to the NetCore Quiz");
            Console.WriteLine("Let's get started, please enter any number to enter the program");
            start = Convert.ToInt32(Console.ReadLine());
        }
    }
}
