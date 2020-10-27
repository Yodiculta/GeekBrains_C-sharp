using System;
/*
 * 3. *Описать класс дробей ­ рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2
задачи. Все программы сделайть в одном решении.
*/
namespace Task_3added
{
    class Fraction
    {
        int Num;
        int Denom;
        public Fraction()
        {
            Num = 0;
            Denom = 0;
        }
        public double ToDouble()
        {
            return (double)Num / Denom;
        }


        public Fraction(int a, int b)
        {
            Num = a;
            Denom = b;
        }
        public Fraction ReBuild()
        {
            int key = 0;
            int i = Denom;
            while (key == 0)
            {
                key = 1;
                for (i = 2; i <=Denom || i <= Num; i++)
                {
                    if (Num % i == 0 && Denom % i == 0)
                    {
                        Num /= i;
                        Denom /= i;
                        key = 0;
                    }
                }
            }
            return new Fraction(Num, Denom);
        }
        public Fraction Plus(Fraction dr)
        {
            return new Fraction(Num * dr.Denom + Denom * dr.Num, Denom * dr.Denom).ReBuild();
        }
        public string ToString()
        {
            return $"{Num}/{Denom}";
        }
        public Fraction Minus(Fraction dr)
        {
            return new Fraction(Num * dr.Denom - Denom * dr.Num, Denom * dr.Denom).ReBuild();
        }
        public Fraction Mult(Fraction dr)
        {
            return new Fraction(Num *dr.Num, Denom * dr.Denom).ReBuild();
        }
    }

    class task3added
    {
        static int Input(out Fraction var)
        {
            Console.Write("input numinator:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("input denominator:");
            int denom = Convert.ToInt32(Console.ReadLine());
            var = new Fraction(num, denom);
            if (denom == 0)
                return -1;
            return 0;
        }
        static void ArgumentException()
        {
            Console.WriteLine("Знаменатель не может быть равен 0");

        }
        static void Main()
        {

            Console.WriteLine("The third homewor in geekbrains. Task 3\n");
            int number = 1;
            Fraction var1 = new Fraction(0, 0);
            Fraction var2 = new Fraction(0, 0);
            int key = 1;
            while (number > 0 || number < 5)
            {
                try
                {
                Label:
                    if (key == 1)
                    {
                        Console.WriteLine("Input of first number: ");
                        if (Input(out var1) == -1)
                        {
                            ArgumentException();
                            goto Label;
                        }
                        Console.WriteLine("Input of second number: ");
                        if(Input(out var2)==-1)
                        {
                            ArgumentException();
                            goto Label;
                        }
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
                    Console.WriteLine("\n1) Fold\n2) Subtract\n3) Multiply\n4) ToDouble \n5)Exit\n");
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
                        case 4:
                            Console.WriteLine(var1.ToDouble());
                            Console.WriteLine(var2.ToDouble());
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
