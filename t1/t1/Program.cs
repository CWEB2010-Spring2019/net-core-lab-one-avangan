using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace t1
{
    class Program
    {
        // Start of the main method
        static void Main(string[] args)
        {
            // Declare an array that holds the questions
            string[] quizQuestions = { "1 NET Core is composed from which of the following parts:?",
                                       "2 What frameworks have been built on top of .netcore ? ",
                                       "3 How much does .netcore cost a month ?",
                                       "4 What platforms does .net core support ? ",
                                       "5 What is the licensing requirements for .netcore ?",
                                       "6 Who was .netcore developed by ?",
                                       "7 What version is .netcore currently on ?",
                                       "8 What year was the original .netcore 1.0 put into production ?",
                                       "9 Net Core is compatiable with which of the following ?",
                                       "10 Which one of the primary lanugauges can be written within .netcore ?"
                                      };

            // Declare a multi-dimensional array that holds options for each of the questions
            string[,] questions = new string[,]{
{ "A) .NET Core runtime","B) ASP.NET runtime","C) .NET Core CLI tools" ,"D) All of the above " },
{ "A)  ASP.NET Core","B)  Windows 10 Universal Windows Platform (UWP)","C) Tizen","D) All of the above " },
{ "A) 50","B) 100 ","C) free","D)89.99 "},
{ "A)Windows ","B) macOS","C) Linux ","D) All of the above" },
{ "A) Open Source","B) Workstation License","C)Apache","D)All of the above" },
{ "A) Oracle ","B)  Microsoft","C) IBM  ","D) All of the above" },
{ "A) 3.0 ","B)5.0","C) 4.0 ","D) All of the above" },
{ "A) 2016","B) 2011","C) 200","D) 2002"},
{ "A) .NET Framework","B) Xamarin","C) Mono","D) All of the above" },
{ "A) C# ","B) Visual Basic","C)  F# languages","D) All of the above" },

                                 };

            // Declare an array that holds the correct answers
            string[] ans = new string[10] { "D", "D", "C", "D", "A", "B", "A", "A", "D", "D" };

            // Declare an array to hold end-user selections
            string[] userSelection = new string[10];

            string selection;
            int exit = 1;

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            int response;
            string inputString;
            Console.WriteLine("This program tests your knowledge of .NET Core, If you must answer 7 questions correctly to pass ");
            Console.WriteLine("To get started, please enter a number to start the quiz.");
            inputString = Console.ReadLine();
            response = Convert.ToInt32(inputString);
            Console.ReadLine();


            while (exit != 0)
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(quizQuestions[x]);
                    Console.WriteLine("");
                    for (int i = 0; i < questions.GetLength(1); i++)
                    {
                        Console.WriteLine(questions[x, i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Enter A, B, C,D ");
                    selection = Console.ReadLine();
                    userSelection[x] = selection;

                    if (selection == ans[x])
                    {
                        correct.Add(selection);
                    }
                    else
                    {
                        wrong.Add("Question: " + (x + 1) + ") " + selection);

                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length + " correct.");
                Console.WriteLine("");


                if (wrong.Count <= 3)
                {
                    Console.WriteLine("You Passed The Quiz!");
                }
                else if (wrong.Count >= 4)
                {
                    Console.WriteLine("Sorry You did not pass..");
                    Console.WriteLine("");

                }

                if (wrong.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Listed bellow are the incorrect answers");
                    Console.WriteLine(String.Join(", ", wrong));
                    Console.WriteLine("");

                }

                // Give the user options 
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Please enter 0 to exit");
                Console.WriteLine("");
                Console.WriteLine("Please enter 1 to retake the quiz");

                exit = Convert.ToInt32(Console.ReadLine());

            }
        }

        /*  
         private static void Greetings()
         {
             int response;
             string inputString;
             Console.WriteLine("This program tests your knowledge of .NET Core, If you must answer 7 questions correctly to pass ");
             Console.WriteLine("To get started, please enter a number to start the quiz.");
             inputString = Console.ReadLine();
             response = Convert.ToInt32(inputString);
            Console.ReadLine();
         }

        */

    }
}