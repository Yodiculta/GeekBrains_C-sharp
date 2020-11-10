/*
 * 2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.
д) ***Создать метод, который производит частотный анализ текста. 
В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
Здесь требуется использовать класс Dictionary.
*/
using System;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace Task2
{
    
    class Message
    {
       
        string[] file;
        public int count;
        private Regex myReg = new Regex("[^A-Za-zА-Яа-я]");
        public Message(string filename)
        {
            file = File.ReadAllLines(filename);
            Count = count;
        }
        private int Count
        {
            set
            {
                count = file.Length;
            }
            get
            {
                return count;
            }
        }

        public void outPutWordlWithN(int n)
        {

            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (word.Length < n && myReg.IsMatch(word) == false)
                        Console.WriteLine(word);
                }
            }
        }
        public void DelWithSymbol(char symbol)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (word != "")
                        if (word.ToCharArray()[word.Length - 1] == symbol)
                            file[i] = file[i].Remove(file[i].IndexOf(symbol) - word.Length + 1, word.Length);
                }
            }
        }
        public void PrintFile()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(file[i]);
            }
        }
        public string FindMaxWord()
        {
            string Max = "";
            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (word.Length > Max.Length)
                        Max = word;
                }
            }
            return Max;
        }
        public string FindMaxWord(string answer)
        {
            string Max = "";
            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (word.Length > Max.Length && answer.IndexOf(word)==-1)
                        Max = word;
                }
            }
            return Max;
        }
        private int CountOfOneLengthWords(StringBuilder _bigWord)
        {
            int num = 0;
            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (_bigWord.Equals(word))
                        num += 1;
                }
            }
            return num;
        }
        public string StringOfMaxWords(int count)
        {
            StringBuilder answer = new StringBuilder(FindMaxWord());
            string one = answer.ToString();
            answer.Append(" ");

            for (int i = 0; i < count - 1; i++)
            {
                one = FindMaxWord(answer.ToString());
                answer.Append(one);
                answer.Append(" ");
            }
            return answer.ToString();
        }
         public Dictionary<int, string> MyDic(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < count; i++)
            {
                foreach (string word in file[i].Split())
                {
                    if (_bigWord.Equals(word))
                        num += 1;
                }
            }
            Console.WriteLine("Введите имя сотрудника: \n");
            string s;
            for (int j = 0; j < i; j++)
            {
                Console.Write("Name{0} --> ", j);
                s = Console.ReadLine();
                dic.Add(j, s);
                Console.Clear();
            }
            return dic;
        }
    }

    class Program
    {
        static void WriteBeautiful(string txt, ConsoleColor txtcolor)
        {
            Console.ForegroundColor = txtcolor;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main()
        {
            WriteBeautiful("The 5th homework in geekbrains. Task 2", ConsoleColor.Red);
            string filename = @"C:\Users\Dasha\Desktop\GEEKBRAINS\GBrainCsharp\Homework5\Homework5_2\Task2\Message.txt";
            if (File.Exists(filename))
            {
                Message Msg = new Message(filename);

                int number = 1, key = 1;
                while ((number > 0 || number < 4) && key == 1)
                {
                    key = 0;
                    WriteBeautiful("1 Вывести только те слова сообщения, которые содержат не более n букв.", ConsoleColor.Red);
                    WriteBeautiful("2 Удалить из сообщения все слова, которые заканчиваются на заданный символ.", ConsoleColor.Red);
                    WriteBeautiful("3 Найти самое длинное слово сообщения.", ConsoleColor.Red);
                    WriteBeautiful("4 Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.", ConsoleColor.Red);
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            WriteBeautiful("Input the number of literals", ConsoleColor.Blue);
                            Msg.outPutWordlWithN(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 2:
                            WriteBeautiful("Input the symbol", ConsoleColor.Blue);
                            Msg.DelWithSymbol(Convert.ToChar(Console.ReadLine()));
                            Msg.PrintFile();
                            break;
                        case 3:
                            WriteBeautiful("The longest word is: "+Msg.FindMaxWord()+"", ConsoleColor.DarkGreen);
                            break;
                        case 4:
                            WriteBeautiful("The number of words: ", ConsoleColor.Blue);
                            WriteBeautiful("Строка из самых длинных слов:"+ Msg.StringOfMaxWords(Convert.ToInt32(Console.ReadLine())) +"", ConsoleColor.Red);
                            
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
}