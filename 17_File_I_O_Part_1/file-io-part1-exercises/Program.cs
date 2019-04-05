using System;
using System.Collections.Generic;
using System.IO;
using file_io_part1_exercises.Classes;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

            string filename = @"C:\Users\Warren Stowe\exercises\17_File_I_O_Part_1\sample-quiz-file.txt";

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] questionArray = line.Split("|");

                        quizQuestions.Add(new QuizQuestion(questionArray));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            Console.WriteLine("Welcome to the Movie Quiz!" +
                "  There are eight questions.");

            int totalCorrect = 0;
            int totalQuestions = 0;

            for (int i = 0; i < quizQuestions.Count; i++)
            {
                totalQuestions++;
                Console.WriteLine(quizQuestions[i].Question);
                Console.WriteLine($"1: {quizQuestions[i].Answers[0]}" +
                    $"\n2: {quizQuestions[i].Answers[1]}" +
                    $"\n3: {quizQuestions[i].Answers[2]}" +
                    $"\n4: {quizQuestions[i].Answers[3]}\n");

                int input = int.Parse(Console.ReadLine());

                if (quizQuestions[i].Answers[input - 1] == quizQuestions[i].CorrectAnswer)
                {
                    Console.WriteLine("You are correct!");
                    totalCorrect++;
                } else
                {
                    Console.WriteLine($"Incorrect!  The correct answer was {quizQuestions[i].CorrectAnswer}.");
                }

                Console.WriteLine($"You have answered {totalCorrect} out of {totalQuestions}.\n");


            }

            if (totalCorrect == 8)
            {
                Console.WriteLine("Congratulations, you answered all 8 questions!");
            } else if (totalCorrect >= 6)
            {
                Console.WriteLine($"Nice job!  You got {totalCorrect} out of 8!  You're pretty good!");
            } else if (totalCorrect >= 4)
            {
                Console.WriteLine($"You got {totalCorrect} out of 8 . . . that's not bad.");
            } else
            {
                Console.WriteLine($"You got {totalCorrect} out of 8.  You must have better things to do than watching movies!");
            }

            Console.ReadKey();
            

        }
    }
}
