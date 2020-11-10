/*Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести
количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче
под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти
элементов: 6; 2; 9; –3; 6 – ответ: 4.*/

using System;

namespace Homework4
{
    class Program
    {
        static int ThreeDenom(int nom)
        {
            return (nom % 3 == 0) ? 0 : 1;
        }
        static void Main()
        {
            Console.WriteLine("The fourth homework in geekbrains. Task 1");
            int[] args = new int[20];
            Random rnd = new Random();
            int i = 0, j = 0;
            for (; i < 20; i++)
            {
                args[i] = rnd.Next(-10000, 10000);
            }
            for (i=0; i < 19; i++)
            {
                if(ThreeDenom(args[i])==0|| ThreeDenom(args[i+1]) == 0)
                {
                    //Console.WriteLine($"{args[i]},{args[i+1]}");
                    j++;
                }
            }
            Console.WriteLine($"the count of pars is {j}");
        }
    }
}
