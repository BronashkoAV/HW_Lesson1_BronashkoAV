using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson1_BronashkoAV
{
    class Program
    {

        static Person pers = new Person();
        static bool flagAnketa = false;
        //comment
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Для начала рекомендую вам заполнить анкету.");
            System.Threading.Thread.Sleep(1000);
            MainMenu();
            Console.ReadKey();
        }

        static void Anketa()
        {
            Console.WriteLine("Заполните, пожалуйста, анкету:");
            Console.WriteLine("Введите ваше имя:");
            pers.Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            pers.SurName = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            pers.Age = ReadLineAndConvertationToFloat();
            Console.WriteLine("Введите город вашего проживания:");
            pers.City = Console.ReadLine();
            Console.WriteLine("Введите ваш рост:");
            pers.Height = ReadLineAndConvertationToFloat();
            Console.WriteLine("Введите ваш вес:");
            pers.Weight = ReadLineAndConvertationToFloat();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("A)\nВаше имя: " + pers.Name + ";\nВаша фамилия: " + pers.SurName + ";\nВаш возраст: " + pers.Age + ";\nВаш рост: " + pers.Height + ";\nВаш вес: " + pers.Weight + ".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Б)\nВаше имя: {0};\nВаша фамилия:  {1};\nВаш возраст: {2};\nВаш рост: {3};\nВаш вес: {4}.", pers.Name, pers.SurName, pers.Age, pers.Height, pers.Weight);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"В)\nВаше имя: {pers.Name};\nВаша фамилия:  {pers.SurName};\nВаш возраст: {pers.Age};\nВаш рост: {pers.Height};\nВаш вес: {pers.Weight}.");
            System.Threading.Thread.Sleep(1000);
            flagAnketa = true;
            MainMenu();
        }

        static int ReadLineAndConvertationToInt()
        {
            bool isInt = false;
            int res;
            do
            {
                string s = Console.ReadLine();
                isInt = Int32.TryParse(s, out res);
                if (!isInt) Console.WriteLine("Вы ввели не число! повторите попытку!");
            } while (!isInt);
            return res;
        }

        static float ReadLineAndConvertationToFloat()
        {
            bool isFloat = false;
            float res;
            do
            {
                string s = Console.ReadLine();
                isFloat = float.TryParse(s, out res);
                if (!isFloat) Console.WriteLine("Вы ввели не число! повторите попытку!");
            } while (!isFloat);
            return res;
        }

        static void Index()
        {
            if (!flagAnketa)
            {
                Console.WriteLine("Вы еще не заполнили анкету, заполните, пожалуйста, её сейчас.");
                System.Threading.Thread.Sleep(1000);
                Anketa();
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(pers.Name + ", индекс массы вашего тела составляет: " + (pers.Weight / (Math.Pow((pers.Height / 100), 2))));
            System.Threading.Thread.Sleep(1000);
            MainMenu();
        }

        static void Distance()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Определение расстояния между двумя точками.");
            float x1, y1, x2, y2, res;
            Console.WriteLine("Введите координату x1:");
            x1 = ReadLineAndConvertationToFloat();
            Console.WriteLine("Введите координату y1:");
            y1 = ReadLineAndConvertationToFloat();
            Console.WriteLine("Введите координату x2:");
            x2 = ReadLineAndConvertationToFloat();
            Console.WriteLine("Введите координату y2:");
            y2 = ReadLineAndConvertationToFloat();
            res = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Расстояние между двумя точками равно: {res:F2}");
            System.Threading.Thread.Sleep(1000);
            MainMenu();
        }

        static void Swap()
        {
            Console.WriteLine("Свапнуть переменные. Первый способ с использованием 3-х переменных (подходит для строк):");
            System.Threading.Thread.Sleep(1000);
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string temp;
            Console.WriteLine($"Was first = {first}, and second = {second}.");
            System.Threading.Thread.Sleep(1000);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine($"Now first = {first}, and second = {second}.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Свапнуть переменные. Второй способ с использованием 2-х переменных (подходит для чисел):");
            System.Threading.Thread.Sleep(1000);
            float a = ReadLineAndConvertationToFloat();
            float b = ReadLineAndConvertationToFloat();
            Console.WriteLine($"Was a = {a}, and b = {b}.");
            System.Threading.Thread.Sleep(1000);
            a = a + b;
            b = -(b - a);
            a = a - b;
            Console.WriteLine($"Now a = {a}, and b = {b}.");
            System.Threading.Thread.Sleep(1000);
            MainMenu();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            System.Threading.Thread.Sleep(1000);
            MainMenu();
        }

        static void MainMenu()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Это главное меню!\nВыберите пункт меню и введите соответствующую цифру:");
            Console.WriteLine("1)Заполнить анкету");
            Console.WriteLine("2)Определить индекс тела");
            Console.WriteLine("3)Определить расстояние между двумя точками");
            Console.WriteLine("4)Поменять местами две переменные");
            Console.WriteLine("5)Вывести ваше имя, фамилию и город в указанных координатах");
            Console.WriteLine("6)В разработке...");
            Console.WriteLine("7)В разработке...");
            Console.WriteLine("8)В разработке...");
            Console.WriteLine("9)В разработке...");
            Console.WriteLine("0)Выйти");
            int flagMenu = ReadLineAndConvertationToInt();
            switch (flagMenu)
            {
                case 1:
                    Anketa();
                    break;
                case 2:
                    Index();
                    break;
                case 3:
                    Distance();
                    break;
                case 4:
                    Swap();
                    break;
                case 5:
                    if (!flagAnketa)
                    {
                        Console.WriteLine("Вы еще не заполнили анкету, заполните, пожалуйста, её сейчас.");
                        System.Threading.Thread.Sleep(1000);
                        Anketa();
                    }
                    Console.WriteLine("Введите сначала координату X, а потом координату Y:");
                    Print($"Ваше имя: {pers.Name}; Ваша фамилия: {pers.SurName}; Вы живёте в город: {pers.City}", ReadLineAndConvertationToInt(), ReadLineAndConvertationToInt());
                    System.Threading.Thread.Sleep(1000);
                    MainMenu();
                    break;
                case 6:                    
                case 7:                   
                case 8:                   
                case 9:
                    Console.WriteLine("Данный пункт находится в разработке..\nВозврат к главному меню..");
                    System.Threading.Thread.Sleep(1000);
                    MainMenu();
                    break;
                case 0:
                    Console.WriteLine("До свидания!");
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }
    }
} 
