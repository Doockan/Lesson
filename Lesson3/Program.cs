using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    struct Complex
    {
        public double re;
        public double im;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;

            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;

            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im;
            y.im = im * x.re + re * x.im;

            return y;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }



    }

    class Complexx
    {
        private double re;
        private double im;

        public Complexx()
        {

        }

        public Complexx(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            this.re = re;
            this.im = im;
        }

        public Complexx Plus(Complexx x)
        {
            return new Complexx(re + x.re, im + x.im);             
        }

        public Complexx Minus(Complexx x)
        {
            return new Complexx(re - x.re, im - x.im);
        }

        public Complexx Multi(Complexx x)
        {
            return new Complexx(re * x.re - im * x.im, im * x.re + re * x.im);
        }      

        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // вторая попытка запулить
                Console.Clear();
                Console.Title = "DZ3";
                Console.WriteLine("Выбериет номер домашнего задания");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Task 1");
                Console.WriteLine("2 - Task 2");
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
            Console.Title = "Task1";
            Console.WriteLine("Struct вычитание");
            Console.WriteLine("================================");

            Complex ty;
            Complex tr;

            Console.Write("Введите действительную часть первого числа: ");
            ty.re = double.Parse(Console.ReadLine());

            Console.Write("Введите мнимую часть первого числа: ");
            ty.im = double.Parse(Console.ReadLine());

            Console.Write("Введите действительную часть второго числа: ");
            tr.re = double.Parse(Console.ReadLine());

            Console.Write("Введите мнимую часть второго числа: ");
            tr.im = double.Parse(Console.ReadLine());
            Console.WriteLine("================================");

            Console.WriteLine(ty.Minus(tr));
            Console.ReadLine();

            Console.Clear();            
            Console.WriteLine("Class вычитание, произведение.");
            Console.WriteLine("================================");

            Console.Write("Введите действительную часть первого числа: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите мнимую часть первого числа: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите действительную часть второго числа: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.Write("Введите мнимую часть второго числа: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("================================");

            Complexx e = new Complexx(a, b);
            Complexx r = new Complexx(a2, b2);

            Console.WriteLine("Вычитание: " + e.Minus(r));
            Console.WriteLine("Произведение: " + e.Multi(r));

            Console.ReadLine();
        }

        static void Task2()
        {
            Console.Clear();
            Console.Title = "Task2";
            Console.WriteLine("Подсчет сумм всех нечетных положительных чисел");
            Console.WriteLine("================================");

            int x = 0;
            int i;
            int a;
            bool flag;
            while (true)
            {
                Console.Write("Введите число:");
                flag = int.TryParse(Console.ReadLine(), out i);
                if (flag)
                {
                    a = i;
                    if (a == 0) break;
                    x = (a % 2 == 0 || a < 0) ? x : x + a;
                }
                else
                {
                    Console.WriteLine("Некорректо введенные данные");
                }    
            }

            Console.WriteLine("================================");
            Console.WriteLine("Сумма нечетных введенных чисел: {0}", x);
            Console.ReadLine();
            
        }        
    }
}
