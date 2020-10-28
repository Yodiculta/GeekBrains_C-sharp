/* Баютова
 * Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
*/
using System;
using System.IO;
using System.Globalization;

namespace Homework4
{
    class StaticClass
    {
        int[] array;
        public StaticClass(int n)
        {
            array = new int[n];
        }

        public void InitArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
        }
        public StaticClass(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);

           
                int N = int.Parse(sr.ReadLine());
                array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        static int ThreeDivis(int nom)
        {
            return (nom % 3 == 0) ? 0 : 1;
        }
        public int CountOfThreeDenomPars()
        {
            int i = 0, j = 0;
            for (; i < array.Length - 1; i++)
            {
                if (ThreeDivis(array[i]) == 0 || ThreeDivis(array[i + 1]) == 0)
                {
                    //Console.WriteLine($"{array[i]},{array[i+1]}");
                    j++;
                }
            }
            return j;
        }
        public void Output()
        {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{array[i]}");
                }
        }
    }

    class Program
    {
        static int [] FileReader(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);


                int N = int.Parse(sr.ReadLine());
                int [] array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
                return array;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }
        }

    static void Main()
        {
            Console.WriteLine("The fourth homework in geekbrains. Task 1");
            string filename= @"C:\Users\Dasha\Desktop\GEEKBRAINS\GBrainCsharp\Homework4\Task2\Homework4\data1.txt";

            if (File.Exists(filename))
            {

                StaticClass args = new StaticClass(filename);
                //args.Output();
                Console.WriteLine(args.CountOfThreeDenomPars());
            }
            else
            {
                StaticClass args = new StaticClass(20);
                args.InitArray();
                //args.Output();
                Console.WriteLine(args.CountOfThreeDenomPars());
            }



        }
    }
}
