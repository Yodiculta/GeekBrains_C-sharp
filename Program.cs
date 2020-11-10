/*
 Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */
using System;

    public delegate double Fun(double x, double a);

class Program
{
    public static void Table(Fun F, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    public static double MySin(double x, double a)
    {
        return a*Math.Sin(x);
    }
    public static double MySQR(double x, double a)
    {
        return a * x*x;
    }

    static void Main()
    {
        Console.WriteLine("Таблица функции MyFunc:");     
        
        Console.WriteLine("Таблица функции aSin:");
        Table(MySin, -2, 2);
        Console.WriteLine("Таблица функции x^2:");
        Table(MySQR, -2, 2);
    }
}
