/*
1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.
*/
using System;
using System.Text.RegularExpressions;
namespace Task1
{
    class Program
    {
        static bool RegularCheckingLogin(string txt)/// using regular functions
        {
            Regex myReg = new Regex("[^A-Za-z0-9]");
            char first = txt.ToCharArray()[0];
            if (myReg.IsMatch(txt) == false && txt.Length > 2 && txt.Length < 10 && char.IsNumber(first) == false)
                return true;
            return false;
        }
        static bool ANRegularCheckingLogin(string txt)/// using regular functions
        {
            char[] first = txt.ToCharArray();
            if (char.IsNumber(first[0]) == false && first.Length > 2 && first.Length < 10)
                foreach (char a in first)
                {
                    if (char.IsNumber(a) == false && char.IsLetter(a) == false)
                        return false;
                }
            else
                return false;
            return true;
            
        }

        static void WriteBeautiful(string txt, ConsoleColor txtcolor)
        {
            Console.ForegroundColor = txtcolor;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args)
        {
            WriteBeautiful("The 5th homework in geekbrains. Task 1", ConsoleColor.Red);
            WriteBeautiful("Input the login: ", ConsoleColor.Blue);
            string login;
            while ((login = Console.ReadLine()) != "stop")
            {
                if (ANRegularCheckingLogin(login) == true)
                {
                    WriteBeautiful("Ok", ConsoleColor.Blue);
                    WriteBeautiful("Input the login: ", ConsoleColor.Blue);
                }
                else
                    WriteBeautiful("try again", ConsoleColor.Blue);
            }
        }
    }
}
