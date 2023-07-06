using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task1
{
    public class CreateQuiz
    {
        private List<Question> _questions;

        public CreateQuiz(string filePath)
        {
            _questions = new List<Question>();
            if(File.Exists(filePath))
            {
                return;
            }
            else
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
            }
        }

        public void AddQuestion(string question, int score, List<string> options, int correctAnswer)
        {
            var newQuestion = new Question
            {
                QuestionP = question,
                Score = score,
                Options = options,
                CorrectAnswer = correctAnswer
            };

            _questions.Add(newQuestion);
        }

        public void ClearQuiz(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }

        public void SaveFileQuiz(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                foreach (var question in _questions)
                {
                    int i = 1;
                    writer.WriteLine($"Question: {question.QuestionP}");
                    writer.WriteLine($"Score: {question.Score}");
                    foreach (var option in question.Options)
                    {
                        writer.WriteLine($"{i}) {option}");
                        i++;
                    }
                    writer.WriteLine($"Correct Answer: {question.CorrectAnswer}");
                    writer.WriteLine();
                }
            }
        }

        public int ReadFileAndFillQuiz(string filePath)
        {
            string[] lines = File.ReadLines(filePath).ToArray();

            int scoreSum = 0;

            for (int i = 0; i < lines.Length; i += 7)
            {
                string question = lines[i];
                int score = int.Parse(lines[i + 1].Substring(6).Trim());

                var options = new List<string>();

                options.Add(lines[i + 2]);
                options.Add(lines[i + 3]);
                options.Add(lines[i + 4]);

                string correctAnswer = lines[i + 5].Substring(15).Trim();

                Console.WriteLine(question);
                Console.WriteLine("Score: " + score);
                Console.WriteLine("Options:");
                foreach (string option in options)
                {
                    Console.WriteLine(option);
                }
                Console.WriteLine();

                Console.WriteLine("Choose Correct Answer: ");
                string answer = Console.ReadLine();
                if (answer == correctAnswer)
                {
                    Console.WriteLine("The answer is correct!");
                    scoreSum += score;
                }
                else
                {
                    Console.WriteLine("The answer is incorrect!");
                }

                Console.WriteLine();
            }

            return scoreSum;
        }

        public bool IsFileEmpty(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            if(lines.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PrintQuestions()
        {
            Console.WriteLine("Questions:" + '\n');
            foreach (var question in _questions)
            {
                int i = 1;
                Console.WriteLine("Question: " + question.QuestionP);
                Console.WriteLine("Score: " + question.Score);
                Console.WriteLine("Options:");
                foreach (var option in question.Options)
                {
                    Console.WriteLine($"{i}) {option}");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
