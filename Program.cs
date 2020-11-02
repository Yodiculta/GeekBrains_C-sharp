/*
Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
Создайте структуру Account, содержащую Login и Password.
Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
using System;
using System.IO;

namespace Homework4
{
    class Login
    {
        public string [] login;
        public string [] password;
        public int num;
        
        public Login(string filename)
        {
            try
            {
                string[] array;
                StreamReader sr = new StreamReader(filename);
                num = int.Parse(sr.ReadLine());
                array = new string[num * 2];//the number of logins
                for (int i = 0; i < num * 2; i++)

                {
                    array[i] = sr.ReadLine();
                }
                sr.Close();
                login = new string[num];
                password = new string[num];
                for (int i = 0, j = 0; i < num * 2; i++, j++)

                {
                    login[j] = array[i];
                    i++;
                    password[j] = array[i];

                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public void LoginOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{login[i]} {i}");
            }

            }
        public void PasswordOutput()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{password[i]} {i}");
            }

        }
        public int Check(string _login, string _password)
        {

            for (int i = 0; i < num; i++)
            {
                if (_login == login[i] && _password == password[i])
                    return 1;
            }
            return 0;

        }
    }
    class Program
    {
        static int Authorisation(Login array)
        {
            int key = 0, i=0;
            do
            {
                Console.WriteLine("Try to input the login and password.");
                string login;
                string password;
                login = Console.ReadLine();
                password = Console.ReadLine();
                if (array.Check(login, password)==1)
                {
                    key = 1;
                    Console.WriteLine("okey, come in");
                    return 1;
                }
                else
                {
                    i++;
                    Console.WriteLine($"no, its wrong, you can try {3 - i} more times");
                }

            } while (key == 0 && i < 3);
            return 0;
        }
        static void Main()
        {
            Console.WriteLine("The fourth homework in geekbrains. Task 4");
            string filename = @"C:\Users\Dasha\Desktop\GEEKBRAINS\GBrainCsharp\Homework4\Task4\Homework4\data.txt";
            Login array = new Login(filename);
            for (int i = 0; i < array.num; i++)
            {
                Console.WriteLine($"user number {i+1}");
                Console.WriteLine(array.login[i]);
                Console.WriteLine(array.password[i]);
            }
            Authorisation(array);
        }
    }
}
