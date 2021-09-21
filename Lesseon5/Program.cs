using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    class Message
    {
        private static string[] separators = { ",", ".", "?", ":", ";", "!", " ", "(", ")" };
        public static string[] SeparMess(string m)
        {
            string[] words = m.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        public static void Letters(string m, int n)
        {
            for (int i = 0; i < SeparMess(m).Length; i++)
            {
                if (SeparMess(m)[i].Length <= n)
                    Console.Write($"{SeparMess(m)[i]}, ");
            }
        }
        public static void DellSymbl(string m, string n)
        {
            string[] arr = SeparMess(m);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][arr[i].Length - 1] == Convert.ToChar(n))
                    arr[i] = "";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
        public static string SearchLongWords(string m)
        {
            string[] n = SeparMess(m);
            string x = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i].Length > x.Length)
                    x = n[i];
            }
            return x;
        }
        public static void StBuilder(string m)
        {
            StringBuilder longWords = new StringBuilder(1000);

            string[] n = SeparMess(m);
            string x = n[0];

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j].Length > x.Length)
                        x = n[j];
                }
                    longWords.Append($"{x}\n");
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == x)
                        n[j] = "";
                }
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j].Length >= 2)
                        x = n[j];
                }

            }
            Console.WriteLine(longWords.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Title = "DZ4 Yakubov A.N.";
                Console.WriteLine("Выбериет номер домашнего задания");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Task 1");
                Console.WriteLine("2 - Task 2");
                Console.WriteLine("3 - Task 3");
                Console.WriteLine("4 - Task 4");
                Console.WriteLine("0 - Для выхода из программы");
                Console.WriteLine("================================");
                Console.Write("Ввод:");
                int e = int.Parse(Console.ReadLine());

                switch (e)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы!");
                        Console.ReadLine();
                        return;
                    default:
                        break;
                }
            }
        }
        static void Task1()
        {
            Console.Clear();
            Console.Title = "Task1 Yakubov A.N.";
            Console.WriteLine("Создание логина");
            Console.WriteLine("================================");

            Console.WriteLine("Введите Логин:");
            string log = Console.ReadLine();
            Regex reg = new Regex("[a-zA-Z][0-9]");
            
            Console.WriteLine("================================");
            if (log.Length <= 10)
            {
                if (reg.IsMatch(log))
                {
                    Console.WriteLine("Логин сохранен.");

                }
                else
                {
                    Console.WriteLine("Логин должен содержать латинские заглавные, строчные буквы и цифры. ");
                }
            }
            else
            {
                Console.WriteLine("Длина логина превышает 10 символов.");
            }
            Console.ReadLine();
        }
        static void Task2()
        {
            Console.Clear();
            Console.Title = "Task2 Yakubov A.N.";
            Console.WriteLine("Вывести слова содержащие не более n букв.");
            Console.WriteLine("================================");

            Console.WriteLine("Введите максимальное число букв:");
            int n = int.Parse(Console.ReadLine());

            string message = "Зачем вы посетили нас? В глуши забытого селенья Я никогда не знала б вас, Не знала б горького мученья. Души неопытной волненья Смирив со временем(как знать?), По сердцу я нашла бы друга, Была бы верная супруга И добродетельная мать.";
            Message.Letters(message, n);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Удаление слов заканчивающихся на n букву.");
            Console.WriteLine("================================");

            Console.WriteLine("Введите букву:");
            string s = Console.ReadLine();

            Console.WriteLine("================================");
            Message.DellSymbl(message, s);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Найти самое длинное слово");
            Console.WriteLine("================================");

            Console.WriteLine(message);
            Console.ReadLine();

            Console.WriteLine("================================");
            Console.WriteLine(Message.SearchLongWords(message));
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Список 3 самых длинных слов");
            Console.WriteLine("================================");

            Console.WriteLine(message);
            Console.ReadLine();

            Console.WriteLine("================================");
            Message.StBuilder(message);
            Console.ReadLine();






        }
        static void Task3()
        {
            Console.Clear();
            Console.Title = "Task3 Yakubov A.N.";
            Console.WriteLine("Проверка на перестановку букв");
            Console.WriteLine("================================");

            Console.WriteLine("Введите первое слово");
            string x1 = Console.ReadLine();
            List<char> x11 = new List<char>();

            for (int i = 0; i < x1.Length; i++)
            {
                x11.Add(x1[i]);
            }
            x11.Sort();

            Console.WriteLine("Введите второе слово");
            string x2 = Console.ReadLine();
            List<char> x22 = new List<char>();

            for (int i = 0; i < x2.Length; i++)
            {
                x22.Add(x2[i]);
            }
            x22.Sort();

            StringBuilder x111 = new StringBuilder();
            foreach (char x in x11)
            {
                x111.Append(x);
            }

            StringBuilder x222 = new StringBuilder();
            foreach (char x in x22)
            {
                x222.Append(x);
            }

            Console.WriteLine("================================");
            if (x11.ToString() == x222.ToString())
            {
                Console.WriteLine("Второе слово являеться перестановкой первого");
            }
            else
            {
                Console.WriteLine("Второе слово не являеться перестановкой первого");
            }
            Console.ReadLine();
        }
        static void Task4()
        {
            Console.Clear();
            Console.Title = "Task4 Yakubov A.N.";
            Console.WriteLine("");
            Console.WriteLine("================================");



            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
