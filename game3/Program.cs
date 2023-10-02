using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {

        static int EnterChoise()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal number) && Int32.Parse(input) <= 4 && Int32.Parse(input) > 0)
                {
                    return (Int32.Parse(input));
                }
                else
                {
                    Console.WriteLine("Повторите ввод числа");
                }
            }

        }


        static int checker()
        {
            while (true)
            {
                Console.WriteLine("Введите число:");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal number) && Int32.Parse(input) > 0)
                {
                    return (Int32.Parse(input));
                }
                else
                {
                    Console.WriteLine("Повторите ввод числа");
                }
            }

        }

        static int operatingMode()
        {

            Console.WriteLine("Добро пожаловать\n1.Игра угадай число\n2.Таблица умножения\n3.Поиск делителей числа\n4.Выйти с программы");
            int mode = EnterChoise();

            switch (mode)
            {
                case 1:
                    gameSearchValue();
                    break;

                case 2:
                    multiplication_table();
                    break;

                case 3:
                    Finding_the_divisor_of_a_number();
                    break;

                case 4:
                    return 0;

            }

            return 0;
        }

        static int gameSearchValue()
        {

            Random rnd = new Random();
            int RandomValue = rnd.Next(0, 100);
            int userValue;

            Console.WriteLine("Число Загадано от 0-100\n");
            while (true)
            {
                userValue = checker();
                if (userValue == RandomValue)
                {
                    Console.WriteLine("Вы угадали число");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    operatingMode();
                    return 0;
                }

                else
                {
                    Console.WriteLine("Вы не угадали повторите попытку");
                }
            }
        }

        static int multiplication_table()
        {
            int[,] Table;
            int n = 10;
            Table = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Table[i, i] = i * i;
                for (int j = i + 1; j < n; j++)
                {
                    Table[i, j] = Table[j, i] = i * j;
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write(Table[i, j] + " ");

                }
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            operatingMode();
            return 0;
        }


        static int Finding_the_divisor_of_a_number()
        {
            int Value = checker();

            Console.WriteLine("Делители равны:");
            for (int i = Value; i > 0; i--)
            {
                if (Value % i == 0)
                {
                    Console.Write(i + " ");
                }

            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            operatingMode();
            return 0;
        }

        static void Main(string[] args)
        {
            operatingMode();
        }
    }

}



