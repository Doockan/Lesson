using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Lesson4
{
    class MyArray
    {

        int[] arr;

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public MyArray(int counter)
        {
            Random random = new Random();

            arr = new int[counter];

            for (int i = 0; i < counter; i++)
            {
                int number = random.Next(-10000, 10001);
                arr[i] = number;
            }

        }
        /// <summary>
        /// Создать массив с начальной точкой и с заданным шагом
        /// </summary>
        /// <param name="counter">размер массива</param>
        /// <param name="start">начальное значение (включается в массив)</param>
        /// <param name="step">шаг</param>
        public MyArray(int counter, int start, int step)
        {
            arr = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                int number = start;
                arr[i] = number;
                start = start + step;
            }

        }
        /// <summary>
        /// Возврат массива с изменением знаков на противоположный
        /// </summary>
        /// <returns></returns>
        public MyArray Inverse()
        {
            int[] arr1 = new int[arr.Length];
            MyArray Arr1 = new MyArray(arr1);

            for (int i = 0; i < arr.Length; i++)
            {
                Arr1[i] = arr[i] * -1;
            }
            return Arr1;
        }
        /// <summary>
        /// Умножить каждый элемент массива на вводное значение
        /// </summary>
        /// <param name="a">значение перемножения</param>
        public void Multi(int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * a;
            }
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        public void Print(int i)
        {
        }

        public int GetElement(int index)
        {
            return arr[index];
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        /// <summary>
        /// Получить сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }

        }

        public int MaxCount
        {
            get
            {
                int a = arr.Length;
                return a;
            }
        }

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
    }
    class StaticClass
    {
        public static int PairOfNumbers(MyArray a)
        {
            int res = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 && a[i + 1] % 3 != 0 || a[i] % 3 != 0 && a[i + 1] % 3 == 0)
                {
                    res++;
                }
            }

            return res;
        }
        public static MyArray LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    int[] buf = new int[1000];
                    int counter = 0;

                    while (!reader.EndOfStream)
                    {
                        buf[counter] = int.Parse(reader.ReadLine());
                        counter++;
                    }

                    int[] arr = new int[counter];
                    MyArray Arr = new MyArray(arr);
                    Array.Copy(buf, arr, counter);

                    return Arr;
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
    struct Account
    {

        private string log;
        private string pass;

        public Account(string log, string pass)
        {
            this.log = log;
            this.pass = pass;
        }

        public string Log { get { return log; } set { Log = log; } }
        public string Pass { get { return pass; } set { Pass = pass; } }

        public override string ToString()
        {
            return ($"Логин: {log}, Пароль: {pass}");
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
                Console.WriteLine("2 - Task 3");
                Console.WriteLine("2 - Task 4");
                Console.WriteLine("2 - Task 5");
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
                    case 5:
                        Task5();
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
            Console.WriteLine("Дан массив из 20 случайных чисел, выводит количество пар в которых только 1 число делиться на 3");
            Console.WriteLine("================================");

            int[] a = new int[20];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-10000, 10001);
                Console.WriteLine($"{a[i]}\t");
            }

            int res = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 && a[i + 1] % 3 != 0 || a[i] % 3 != 0 && a[i + 1] % 3 == 0)
                {
                    res++;
                }
            }

            Console.WriteLine("================================");
            Console.WriteLine($"Найдено {res} пар!");
            Console.ReadLine();
        }
        static void Task2()
        {
            Console.Clear();
            Console.Title = "Task2 Yakubov A.N.";
            Console.WriteLine("Реализация 1 задачи в виде статического класса StaticClass");
            Console.WriteLine("================================");

            MyArray arr = StaticClass.LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt");
            arr.Print();
            int r = StaticClass.PairOfNumbers(arr);

            Console.WriteLine("================================");
            Console.WriteLine($"Найдено {r} пар!");
            Console.ReadLine();
        }
        static void Task3()
        {
            Console.Clear();
            Console.Title = "Task3 Yakubov A.N.";
            Console.WriteLine("Дописать класс для работы с одномерным массивом");
            Console.WriteLine("================================");

            Console.WriteLine("Создание массива размером 10, началом -4, шагом 2");
            MyArray arr = new MyArray(11, -4, 2);
            arr.Print();
            Console.WriteLine();

            Console.WriteLine("Свойство Sum, возвращает сумму элементов массива");
            Console.WriteLine(arr.Sum);
            Console.WriteLine();

            Console.WriteLine("Метод Inverse, возвращает новый массив с измененными знаками");
            MyArray Arr = arr.Inverse();
            Arr.Print();
            arr.Print();
            Console.WriteLine();

            Console.WriteLine("Метод Multi, умножает каждый элемент массива на 3");
            Arr.Multi(3);
            Arr.Print();
            Console.WriteLine();

            Console.WriteLine("Свойство MaxCount, возвращает максимальное количество элементов массива");
            Console.WriteLine(Arr.MaxCount);
            Console.WriteLine();


            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.ReadLine();
        }
        static void Task4()
        {
            Console.Clear();
            Console.Title = "Task4 Yakubov A.N.";
            Console.WriteLine("Авторизация с данными введенными в MyPassword.txt");
            Console.WriteLine("================================");
            Console.WriteLine("Нажмите Enter для авторизации");
            Console.ReadLine();

            Account Avaz = new Account("root", "GeekBrains");
            string[] arr = new string[2];

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "MyPassword.txt"))
            {
                Console.WriteLine($"Чтение файла {AppDomain.CurrentDomain.BaseDirectory} MyPassword.txt");
                using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "MyPassword.txt"))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = reader.ReadLine();
                    }
                }
                Console.WriteLine("Завершено чтение файла.");
            }
            else
            {
                throw new FileNotFoundException();
            }


            Account checker = new Account($"{arr[0]}", $"{arr[1]}");

            Console.WriteLine("================================");
            Console.WriteLine(Avaz.Log == checker.Log && Avaz.Pass == checker.Pass ? "Авторизация прошла успешно!": "Неверный логин или пароль!");
            Console.ReadLine();
        }
        static void Task5()
        {
            Console.Clear();
            Console.Title = "Task5 Yakubov A.N.";
            Console.WriteLine("Демонстрация библиотеки для работы с двумерным масивом");
            Console.WriteLine("==================================");

            Console.WriteLine("Создание массива [5,5]");
            Array2 arr = new Array2(5, 5);
            arr.Print();
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}\n");

            Console.WriteLine($"Сумма элеметов массива значение который больше 50: {arr.SumFor(50)}\n");

            Console.WriteLine($"Возврат минимального элемента массива: {arr.Min}\n");

            Console.WriteLine($"Возврат максимального элемента массива: {arr.Max}\n");

            string x;
            arr.MaxOut(out x);
            Console.WriteLine($"Возврат номера максимального элемента через парамент out: {x}");

            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
