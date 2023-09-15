using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Здравствуйте! Как Вас зовут?");
                string userName = Console.ReadLine();
                int countQuestions = 5;
                int countDiagnosis = 6;
                int countRightAnswer = 0;
                string[] questions = GetQuestions(countQuestions);
                int[] answers = GetAnswers(countQuestions);
                Shuffle(questions, answers);

                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос № " + (i + 1));
                    Console.WriteLine(questions[i]);
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    int rightAnswer = answers[i];
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswer++;
                    }

                }
                Console.WriteLine("Количество правильных ответов " + countRightAnswer);
                string[] diagnosis = GetDiagnosis(countDiagnosis);
                Console.WriteLine(userName + "," + " Ваш диагноз " + diagnosis[countRightAnswer]);
                bool restart = GetRestart("Хотите начать сначала?");
                if (restart == false)
                {
                    break;
                }
            }
        }
        static bool GetRestart(string message)
        {
            while (true)
            {
                Console.WriteLine(message + "Напишите Да или Нет");
                string responce = Console.ReadLine();
                if (responce.ToLower() == "да")
                {
                    return true;
                }
                if (responce.ToLower() == "нет")
                {
                    return false;
                }
            }

        }
        static string[] GetDiagnosis(int countDiagnosis)
        {
            string[] diagnosis = new string[countDiagnosis];
            diagnosis[0] = "Идиот";
            diagnosis[1] = "Кретин";
            diagnosis[2] = "Дурак";
            diagnosis[3] = "Нормальный";
            diagnosis[4] = "Талант";
            diagnosis[5] = "Гений";

            return diagnosis;
        }
        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            return questions;
        }
        static int[] GetAnswers(int countQuestions)
        {
            int[] answers = new int[countQuestions];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;
            return answers;
        }
        static void Shuffle(string[] questions, int[] answers)
        {
            Random random = new Random();
            int randomNumber;
            string reserveString;
            int reserveInt;
            for (int i = 5 - 1; i >= 1; i--)
            {
                randomNumber = random.Next(i + 1);
                reserveString = questions[randomNumber];
                questions[randomNumber] = questions[i];
                questions[i] = reserveString;
                reserveInt = answers[randomNumber];
                answers[randomNumber] = answers[i];
                answers[i] = reserveInt;

            }
            return;
        }
    }
}
