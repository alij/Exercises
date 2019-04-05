using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises.Classes
{
    public class QuizQuestion
    {
        public string Question { get; }
        public List<string> Answers { get; } = new List<string>();
        public string CorrectAnswer { get; }

        public QuizQuestion() { }

        public QuizQuestion(string[] question)
        {
            Question = question[0];
            Answers.Add(question[1]);
            Answers.Add(question[2]);
            Answers.Add(question[3]);
            Answers.Add(question[4]);
            CorrectAnswer = FindCorrectAnswer(Answers);
        }

        public string FindCorrectAnswer(List<string> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].Contains("*"))
                {
                    answers[i] = answers[i].Remove(answers[i].Length - 1);
                    return answers[i];
                }
            }

            return "";
        }


    }
}

