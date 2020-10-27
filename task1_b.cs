using System;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace Homework3
{
    class Complex
    {
        double im;
        double re;
        public Complex()
        {
            im = 0;
            re = 0;
        }
        public Complex(double x, double y)
        {
            this.im = y;
            this.re = x;

        }
        public Complex Plus(Complex x)
        {
            Complex y = new Complex(0, 0);
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Mult(Complex x)
        {
            Complex y = new Complex(0, 0);
            y.re = re * x.re + im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y = new Complex(0, 0);
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public string ToString()
        {
            if (im < 0) return String.Format("{0:#.##} {1:#.##}i", re, im);
            else return String.Format("{0:#.##} +{1:#.##}i", re, im);
        }
    }
    class task1_b
    {
        static void Input(out Complex var)
        {
            Console.Write("input Re:");
            double re = Convert.ToDouble(Console.ReadLine());
            Console.Write("input Im:");
            double im = Convert.ToDouble(Console.ReadLine());
            var = new Complex(re, im);
        }

        static void Main()
        {

            Console.WriteLine("The third homewor in geekbrains. Task 1(b)");
            int number = 1;
            Complex var1=new Complex(0,0);
            Complex var2 = new Complex(0, 0);
            int key = 1;
            while (number > 0 || number < 5)
            {
                try
                {
                    Label:
                    if (key == 1)
                    {
                        Console.WriteLine("Input of first number: ");
                        Input(out var1);
                        Console.WriteLine("Input of second number: ");
                        Input(out var2);
                    }
                    else
                        {
                        Console.WriteLine($"To continue with result {var1.ToString()} ?(yes/no)");
                        if (Console.ReadLine() == "yes")
                        {
                            Console.WriteLine("Input of second number: ");
                            Input(out var2);
                        }
                        else
                        {
                            key = 1;
                            goto Label;
                        }
                    }
                    key = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{var1.ToString()} ? {var2.ToString()} = RESULT");
                    Console.WriteLine("\n1) Fold\n2) Subtract\n3) Multiply\n4) Exit\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Console.Write($"{var1.ToString()}+{var2.ToString()}=");
                            Console.WriteLine(var1.Plus(var2).ToString());
                            var1 = var1.Plus(var2);
                            break;
                        case 2:
                            Console.Write($"{var1.ToString()}-{var2.ToString()}=");
                            Console.WriteLine(var1.Minus(var2).ToString());
                            var1 = var1.Minus(var2);
                            break;
                        case 3:
                            Console.Write($"({var1.ToString()})*({var2.ToString()})=");
                            Console.WriteLine(var1.Mult(var2).ToString());
                            var1 = var1.Mult(var2);
                            break;
                        default:
                            Console.WriteLine("Have a nice day!");//TASK_6
                            Environment.Exit(0);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Input some number in {1...6}");//TASK_6
                }
            }
        }
    }
}