/*
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

*/
using ArrayLib;
using System;
namespace Homework4
{
    class Task3b
    {
        static void WriteBeautiful(string txt, ConsoleColor txtcolor)
        {
            Console.ForegroundColor = txtcolor;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The fourth homework in geekbrains. Task 3a");
            int number = 1;
            int key = 1;
            int size = 0;
            OneDimArray array = new OneDimArray(20);
            while ((number > 0 || number < 4) && key == 1)
            {
                key = 0;
                WriteBeautiful("the method of input:\n1)Randomazer;\n2)From file\n3)With step", ConsoleColor.Red);
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        WriteBeautiful("Input the size", ConsoleColor.Blue);
                        size = Convert.ToInt32(Console.ReadLine());
                        array = new OneDimArray(size);
                        array.InitArray();
                        break;
                    case 2:
                        string filename = @"C:\Users\Dasha\Desktop\GEEKBRAINS\GBrainCsharp\Homework4\Task2\Homework4\data.txt";
                        array = new OneDimArray(filename);
                        break;
                    case 3:
                        WriteBeautiful("Input the size", ConsoleColor.Blue);
                        size = Convert.ToInt32(Console.ReadLine());
                        WriteBeautiful("Input first element", ConsoleColor.Blue);
                        int first = Convert.ToInt32(Console.ReadLine());
                        WriteBeautiful("Input the step", ConsoleColor.Blue);
                        int step = Convert.ToInt32(Console.ReadLine());

                        array = new OneDimArray(size, step, first);
                        //array.Output();
                        break;
                    default:

                        Console.WriteLine("Have a nice day!");//TASK_6
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("It's your array");
                array.Output();
                WriteBeautiful("what should i do?", ConsoleColor.Red);
                WriteBeautiful("the method of input:\n1)Sum;\n2)Inverse\n3)Multi\n4)MaxCount", ConsoleColor.Red);
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        int N = array.Sum;
                        Console.WriteLine(N);
                        break;
                    case 2:
                        OneDimArray new_array = array.Invers();
                        WriteBeautiful("The new array:", ConsoleColor.DarkGreen);
                        new_array.Output();
                        WriteBeautiful("The old array:", ConsoleColor.DarkGreen);
                        array.Output();
                        break;
                    case 3:
                        WriteBeautiful("Input the number to multiply:", ConsoleColor.Blue);
                        array.Multi(Convert.ToInt32(Console.ReadLine()));
                        array.Output();
                        break;
                    case 4:
                        WriteBeautiful($"MaxCount:{array.MaxCount}", ConsoleColor.DarkGreen);
                        break;
                    default:
                        Console.WriteLine("Have a nice day!");//TASK_6
                        Environment.Exit(0);
                        break;

                }
                WriteBeautiful("To continue?(yes/no)", ConsoleColor.Blue);

                if (Console.ReadLine() == "yes")
                {
                    key = 1;
                }
            }
        }
    }
}