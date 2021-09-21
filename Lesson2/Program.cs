using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {        
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(bool x)
        {
            Console.WriteLine(x);
        }
        static void Print(string msg, int x)
        {
            Console.WriteLine(msg, x);
        }
        static void Pause()
        {
            Console.ReadLine();
        }      
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.Title = "DZ2";
                Print("Выбериет номер домашнего задания");
                Print("================================");
                Print("1 - Task 1");
                Print("2 - Task 2");
                Print("3 - Task 3");
                Print("4 - Task 4");
                Print("5 - Task 5");
                Print("6 - Task 6");
                Print("7 - Task 7");
                Print("0 - Для выхода из программы");
                Print("================================");
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
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 0:
                        Print("Выход из программы!");
                        Pause();
                        return;
                    default:
                        break;
                }
            }            
            

        }
        static void Task1()
        {
            Console.Clear();
            Console.Title = "Task1";
            Print("Метод возвращения минимального из трех чисел");
            Print("======================");

            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            Print("======================");
            Print("Минимальное число - {0}",a > b ?(b>c?c:b):(a>c?c:a));
            Pause();
        }
        static void Task2()
        {
            Console.Clear();
            Console.Title = "Task2";
            Print("Метод подсчета количества цифр");
            Print("======================");

            Console.Write("Введите число:");
            long a = long.Parse(Console.ReadLine());

            int x = 0;
            do
            {
                a = a / 10;
                x++;
            } while (a > 0);

            Print("======================");
            Print("Количество цифр: {0}",x);
            Pause();
        }

        static void Task3()
        {
            Console.Clear();
            Console.Title = "Task3";
            Print("Подсчет сумм всех нечетных положительных чисел");
            Print("======================");

            int x = 0;
            while(true)
            {
                Console.Write("Введите число:");
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                    break;
                x = (a % 2 == 0 || a < 0) ? x : x + a;               
            }

            Print("======================");
            Print("Сумма нечетных введенных чисел: {0}", x);
            Pause();
        }

        static void Task4()
        {
            Console.Clear();
            Console.Title = "Task4";            

            bool r = false;
            int i = 0;
            do
            {
                Console.Clear();
                Print("Авторизация в терминале");
                Print("======================");

                Console.Write("Логин: ");
                string l = Console.ReadLine();

                Console.Write("Пароль: ");
                string p = Console.ReadLine();

                r = ((l == "root") && (p == "GeekBrains")) ? true : false;
                if (r == false)
                {
                    Print(r);
                    Pause();
                    i++;
                }
                else
                {
                    Print(r);
                    Pause();
                    return;
                }

            } while (i < 3 && r != true);          
        }

        static void Task5()
        {
            Console.Clear();
            Console.Title = "Task5";
            Print("Расчет индекса массы тела");
            Print("======================");

            Console.Write("Рост: ");
            float Height = float.Parse(Console.ReadLine());

            Console.Write("Вес: ");
            float Weight = float.Parse(Console.ReadLine());

            float res = (Weight / (Height * Height))*10000;
            
            Print("======================");
            if (res < 15.99)
                Print("Выраженный дефицит массы тела, необходима срочная консультация специалиста");
            else if (16 < res && res < 18.49)
                Print("Недостаточная (дефицит) масса тела, необходима консультация специолиста");
            else if (18.5 < res && res < 24.99)
                Print("Норма");
            else if (25 < res && res < 29.99)
                Print("Избыточная масса тела (предожирение), необходима консультация специолиста");
            else if (30 < res && res < 34.99)
                Print("Ожирение первой стемени, необходима консультация специолиста");
            else if (35 < res && res < 39.99)
                Print("Ожирение второй степени, необходима консультация специалиста");
            else if (40 < res)
                Print("Ожирение третьей степени (морбидное), необходима консультация специалиста");

            float kg;
            if (res < 18.5f)
            {
                kg = ((18.5f - res) / 10000) * (Height * Height);
                Print($"Вам необходимо набрать минимум {kg:F0} кг. при вашем росте {Height}");
            }
            else if (res > 24.99)
            {
                kg = ((res - 24.99f) / 10000) * (Height * Height);
                Print($"Вам необходимо сбросить минимум {kg:F0} кг. при вашем росте {Height}");
            }            

            Pause();            
        }

        static void Task6()
        {
            Console.Clear();
            Console.Title = "Task6";
            Print("Подсчет количества хороших чисел в диапазоне от 1 до 1 000 000 000");
            Print("======================");
            Console.Write("Нажмите Enter для запуска программы");
            Pause();
            DateTime one = DateTime.Now;
            long res = 0;
            for(long x = 1; x<=1000000000; x++)
            {
                long sum = 0;
                long i = x;
                while (i > 0)
                {
                    sum = sum + (i % 10);
                    i = i / 10;
                }
                if (x % sum == 0) res++;               
            }            
            TimeSpan subTime = DateTime.Now - one;
            Console.WriteLine($"Количество хороших чисел: {res}, время выполнения {subTime.ToString(@"hh\:mm\:ss")}");
           
            Pause();
        }

        static void Task7()
        {
            Console.Clear();
            Console.Title = "Task7";
            Print("Вывод на экран числа от a до b");
            Print("======================");
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            printNum(a, b,sum);
            Pause();

        }
        static void printNum(int a, int b,int sum)
        {
            Console.Write($"{a}  ");
            sum += a;
            if (a < b) printNum(a + 1, b, sum);
            else Console.WriteLine($"Сумма чисел = {sum}");
        }
    }
}
