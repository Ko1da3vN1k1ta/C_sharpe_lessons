﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            // string name = Console.ReadLine();

            // Console.WriteLine($"Hello {name}");

            //2
            // string input = Console.ReadLine(); 
            // string[] numbers = input.Split(' '); 

            // int a = int.Parse(numbers[0]);
            // int b = int.Parse(numbers[1]);

            // Console.WriteLine("Sum: " + (a + b));
            // Console.WriteLine("Subtraction: " + (a - b));
            // Console.WriteLine("Multiplication: " + (a * b));
            // Console.WriteLine("Division: " + (a / b));

            //3
            // int number = 1234;

            // string numberAsString = number.ToString();

            // Console.WriteLine(numberAsString);

            //4
            // string floatString = "123.45";

            // try
            // {
            //     float number = float.Parse(floatString);
            //     Console.WriteLine("String конвертировано во Float: " + number);
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("String в неправильном формате");
            // }
            // catch (OverflowException)
            // {
            //     Console.WriteLine("Строка представляет собой число, меньшее МинЗнач или большее, чем МаксЗнач");
            // }
            //5
            // string input = Console.ReadLine();

            // double celsius;
            // if (double.TryParse(input, out celsius))
            // {
            //     double fahrenheit = (celsius * 9 / 5) + 32;  // Вычисление по формуле
            //     Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
            // }
            // else
            // {
            //     Console.WriteLine("Введены некорректные данные. Пожалуйста, введите числовое значение.");
            // }
            //6
            // Console.Write("Введите количество секунд, прошедших с начала суток: ");
            // string input = Console.ReadLine();

            // // Преобразование введённой строки в число типа int
            // int totalSeconds;
            // if (int.TryParse(input, out totalSeconds))
            // {
            //     // Вычисление времени последних суток
            //     int secondsInADay = 86400;
            //     int secondsToday = totalSeconds % secondsInADay;

            //     // Перевод секунд в часы, минуты и секунды
            //     int hours = secondsToday / 3600;  // 3600 секунд в часе
            //     int minutes = (secondsToday % 3600) / 60;  // Остаток от часов и 60 секунд в минуте
            //     int seconds = secondsToday % 60;  // Остаток от минут

            //     Console.WriteLine($"Текущее время: {hours} часов, {minutes} минут, {seconds} секунд.");
            // }
            // else
            // {
            //     Console.WriteLine("Введены некорректные данные. Пожалуйста, введите целое число.");
            // }
        }
    }
}

