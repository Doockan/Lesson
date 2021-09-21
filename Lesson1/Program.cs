using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание #1
            Console.Title = "Задание #1";

            Print("Зполните пожалуйста информацию о себе.");
            Print("Ваше имя:");
            string name = Console.ReadLine();

            Print("Ваша фамилия:");
            string surname = Console.ReadLine();

            Print("Ваш возрас:");
            string age = Console.ReadLine();

            Print("Ваш рост:");
            string height = Console.ReadLine();

            Print("Ваш вес:");
            string weight = Console.ReadLine();

            Print("Проверьте ваши данные на соответствие");
            Print("Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, surname, age, height, weight);
            Print($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}");

            Pause();
            Console.Clear();
            #endregion

            #region Задание #2
            Console.Title = "Задание #2";

            Print("Расчет ИМТ");
            Print("Ваш вес:");
            float m = int.Parse(Console.ReadLine());

            Print("Ваш рост:");
            float h = int.Parse(Console.ReadLine());

            float l = m / (h * h);

            Print("Ваш индекс массы тела = " + l);

            Pause();
            Console.Clear();
            #endregion

            #region Задание #3
            Console.Title = "Задание #3";

            Print("Расчет расстояние между 2 точками координат");
            Print("Введите координату X1");
            int x1 = int.Parse(Console.ReadLine());

            Print("Расчет расстояние между 2 точками координат");
            Print("Введите координату Y1");
            int y1 = int.Parse(Console.ReadLine());

            Print("Расчет расстояние между 2 точками координат");
            Print("Введите координату X2");
            int x2 = int.Parse(Console.ReadLine());

            Print("Расчет расстояние между 2 точками координат");
            Print("Введите координату Y2");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние между точками = {0:F2}", calcDistance(x1, y1, x2, y2));

            Pause();
            Console.Clear();
            #endregion

            #region Задание #4
            Console.Title = "Задание #4";

            Print("Назначте значени X");
            int x = int.Parse(Console.ReadLine());
            Print("Назначте значени Y");
            int y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Print("Обмен значениями");
            Print("X = " + x);
            Print("Y = " + y);

            Pause();
            Console.Clear();
            #endregion

            #region Задание #5
            Console.Title = "Задание #5";

            string ms = "Якубов Аваз, Тольятти";

            int centerX = (Console.WindowWidth / 2) - (ms.Length / 2);
            int centerY = (Console.BufferHeight / 2) + 1;
            Console.SetCursorPosition(centerX, centerY);

            Print(ms);

            Pause();
            Console.Clear();
            #endregion
        }

        static double calcDistance(int x1, int y1, int x2, int y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Print(string i)
        {
            Console.WriteLine(i);
        }

        static void Pause()
        {
            Console.ReadLine();
        }
    }
}
