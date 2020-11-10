/*
Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 
*/
using System;
using System.Collections.Generic;
using System.IO;
namespace Task2
{
    public delegate double Fun(double x);
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double SinCos(double x)
        {
            return Math.Sin(x)-Math.Cos(x);
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Fun Fun)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Fun(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double []d=new double [fs.Length];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d[i] = bw.ReadDouble();
                if (d[i] < min) min = d[i];
            }
            bw.Close();
            fs.Close();
            return d;
        }
        static void WriteBeautiful(string txt, ConsoleColor txtcolor)
        {
            Console.ForegroundColor = txtcolor;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("The 6th homework in geekbrains. Task 2");
            
            int number = 1;
            int key = 1;
            int left=0, right=0;
            List<Fun> list = new List<Fun>();
            list.Add(F);
            list.Add(SinCos);
            double min;
            while (number > 0 || number < 4)
            {
                Console.WriteLine(Load("data.bin", out min).Length);
                Console.WriteLine(min);
                WriteBeautiful("Choose the one:\n1)x^2-50x+10;\n2) sin(x)-cos(x)\n3)exit", ConsoleColor.Red);
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 3 && number > 0)
                {
                    WriteBeautiful("input the left border", ConsoleColor.Blue);
                    left = Convert.ToInt32(Console.ReadLine());
                    WriteBeautiful("input the left border", ConsoleColor.Blue);
                    right = Convert.ToInt32(Console.ReadLine());
                }

                switch (number)
                {
                    case 1:
                        SaveFunc("data.bin", left, right, 0.5, list[0]);
                        break;
                    case 2:
                        SaveFunc("data.bin", left, right, 0.5, list[1]);
                        break;
                    default:
                        Console.WriteLine("Have a nice day!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
