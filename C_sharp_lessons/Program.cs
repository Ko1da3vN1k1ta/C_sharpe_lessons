using System;
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
            // 1
            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            // Console.WriteLine("Sum: " + (a + b));
            // Console.WriteLine();
            // Console.WriteLine("Substraction: " + (a - b));
            // Console.WriteLine();
            // Console.WriteLine("Multiplication: " + (a * b));
            // Console.WriteLine();
            // Console.WriteLine("Division: " + (a / b));

            //2
            //double l;
            //l = Convert.ToDouble(Console.ReadLine());
            //double s, r;
            //r = l / (2 * 3.14);
            //s = 3.14 * r * r;
            //Console.WriteLine("S={0}  ", s);

            //3
            //int a = int.Parse(Console.ReadLine());;
            //int b = int.Parse(Console.ReadLine());
            //double avgSquares = (Math.Pow(a, 2) + Math.Pow(b, 2)) / 2.0;
            //double avgABS = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            //Console.WriteLine("Среднее арифметическое квадратов чисел: " + avgSquares);
            //Console.WriteLine("Среднее арифметическое модулей чисел: " + avgABS);

            //4
            // double S = double.Parse(Console.ReadLine());
            // double radius = Math.Sqrt(S / Math.PI);
            // double length = 2 * Math.PI * radius;
            // Console.WriteLine("Длина окружности: " + length);

            //5
            //double V = double.Parse(Console.ReadLine());
            //double U = double.Parse(Console.ReadLine());
            //double T1 = double.Parse(Console.ReadLine());
            //double T2 = double.Parse(Console.ReadLine());

            //double S1 = V * T1;
            //double S2 = (V - U) * T2;
            //double S = S1 + S2;

            //Console.WriteLine($"Путь, пройденный лодкой: {S} км");
            //}

            //6
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double alpha = Math.PI / 4;
            //double h = Math.Tan(alpha) * (a - b) / 2;
            //double P = a + b + 2 * Math.Sqrt(h * h + Math.Pow((a - b) / 2, 2));
            //double S = (a + b) * h / 2;
            //Console.WriteLine("Периметр трапеции: " + P);
            //Console.WriteLine("Площадь трапеции: " + S);

            //7
            //double V1 = double.Parse(Console.ReadLine());
            //double V2 = double.Parse(Console.ReadLine());
            //double S = double.Parse(Console.ReadLine());
            //double T = double.Parse(Console.ReadLine());

            //double distance = S + (V1 + V2) * T;

            //Console.WriteLine($"Расстояние между автомобилями через {T} ч: {distance} км");
            //}

            //8
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double alpha = Math.PI / 4;
            //double h = (a - b) / 2 * Math.Tan(alpha);

            //double P = a + b + 2 * h / Math.Cos(alpha);
            //double S = (a + b) * h / 2;

            //Console.WriteLine("Периметр трапеции: " + P);
            //Console.WriteLine("Площадь трапеции: " + S);


            //9
            //double V1 = double.Parse(Console.ReadLine());
            //double V2 = double.Parse(Console.ReadLine());
            //double S = double.Parse(Console.ReadLine());
            //double T = double.Parse(Console.ReadLine());

            //double distance = S - (V1 + V2) * T;

            //Console.WriteLine($"Расстояние между автомобилями через {T} ч: {distance} км");
            //}



            //10
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Console.WriteLine($"Расстояние между точками: {distance}");
            //}


            //11
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());

            //double c = Math.Sqrt(a * a + b * b);
            //double P = a + b + c;
            //double S = 0.5 * a * b;

            //Console.WriteLine("Периметр прямоугольного треугольника: " + P);
            //Console.WriteLine("Площадь прямоугольного треугольника: " + S);

            //12

            //Console.WriteLine("Введите координаты вершин треугольника:");

            //Console.Write("x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            //double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            //double perimeter = a + b + c;

            //double P = perimeter / 2;

            //// Вычисление площади по формуле Герона
            //double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            //Console.WriteLine($"Периметр треугольника: {perimeter}");
            //Console.WriteLine($"Площадь треугольника: {S}");




            //13
            //double circleArea = double.Parse(Console.ReadLine());
            //double radius = Math.Sqrt(circleArea / Math.PI);
            //double circumference = 2 * Math.PI * radius;

            //Console.WriteLine("Длина окружности: " + circumference);


            //14
            //double A = double.Parse(Console.ReadLine());
            //double B = double.Parse(Console.ReadLine());
            //double C = double.Parse(Console.ReadLine());

            //double discriminant = B * B - 4 * A * C;
            //if (discriminant >= 0)
            //{
            //    double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
            //    double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);

            //    Console.WriteLine("Первый корень: " + x1);
            //    Console.WriteLine("Второй корень: " + x2);
            //}
            //else
            //{
            //    Console.WriteLine("Дискриминант отрицателен, корни не могут быть найдены.");
            //}



            //15
            //double radius = double.Parse(Console.ReadLine());

            //double circumference = 2 * Math.PI * radius;
            //double S = Math.PI * Math.Pow(radius, 2);

            //Console.WriteLine("Длина окружности: " + circumference);
            //Console.WriteLine("Площадь круга: " + S);



            //16

            //double A1 = double.Parse(Console.ReadLine());
            //double B1 = double.Parse(Console.ReadLine());
            //double C1 = double.Parse(Console.ReadLine());
            //double A2 = double.Parse(Console.ReadLine());
            //double B2 = double.Parse(Console.ReadLine());
            //double C2 = double.Parse(Console.ReadLine());

            //double determinant = A1 * B2 - A2 * B1;
            //if (determinant != 0)
            //{

            //    double x = (C1 * B2 - C2 * B1) / determinant;
            //    double y = (A1 * C2 - A2 * C1) / determinant;

            //    Console.WriteLine("Решение: x = " + x + ", y = " + y);
            //}
            //else
            //{
            //    Console.WriteLine("Система уравнений не имеет единственного решения.");
            //}

            //17


            //double R1 = double.Parse(Console.ReadLine());
            //double R2 = double.Parse(Console.ReadLine());

            //double ringArea = CalculateRingArea(R1, R2);

            //Console.WriteLine("Площадь кольца: " + ringArea);

            //static double CalculateRingArea(double R1, double R2)
            //{
            //    double area = Math.PI * (R2 * R2 - R1 * R1);

            //    return area;
            //}



            //18
            //int number = int.Parse(Console.ReadLine());

            //int sum = 0;
            //sum += number / 1000 % 10;
            //sum += number / 100 % 10; 
            //sum += number / 10 % 10;  
            //sum += number % 10;       
            //Console.WriteLine("Сумма цифр числа " + number + " равна: " + sum);


            //19
            //double a = double.Parse(Console.ReadLine());

            //double P = 3 * a;
            //double S = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);

            //Console.WriteLine("Периметр равностороннего треугольника: " + P);
            //Console.WriteLine("Площадь равностороннего треугольника: " + S);

            //20
            //int number = int.Parse(Console.ReadLine());

            //int sum = (number / 1000) % 10 + (number / 100) % 10 + (number / 10) % 10 + number % 10;

            //Console.WriteLine("Сумма цифр числа " + number + " равна: " + sum);

            //21
            //Console.Write("Введите расстояние в сантиметрах: ");
            //int distanceInCentimeters = Convert.ToInt32(Console.ReadLine());

            //int meters = distanceInCentimeters / 100;

            //Console.WriteLine($"Количество полных метров: {meters}");

            //22
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int digit1 = number / 100;
            //int digit2 = (number / 10) % 10;
            //int digit3 = number % 10;

            //int sum = digit1 + digit2 + digit3;
            //int product = digit1 * digit2 * digit3;

            //Console.WriteLine($"Сумма цифр: {sum}");
            //Console.WriteLine($"Произведение цифр: {product}");

            //23
            //Console.Write("Введите количество секунд, прошедших с начала суток: ");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());

            //int secondsInLastMinute = totalSeconds % 60;

            //Console.WriteLine($"Количество секунд, прошедших с начала последней минуты: {secondsInLastMinute}");


            //24
            //Console.Write("Введите массу в килограммах: ");
            //int massInKg = Convert.ToInt32(Console.ReadLine());

            //int fullTons = massInKg / 1000;

            //Console.WriteLine($"Количество полных тонн: {fullTons}");

            //25
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int reversedNumber = 0;
            //reversedNumber += number % 10 * 100; 
            //number /= 10; 

            //reversedNumber += number % 10 * 10; 
            //number /= 10; 

            //reversedNumber += number; 

            //Console.WriteLine($"Число, полученное при прочтении исходного числа справа налево: {reversedNumber}");

            //26
            //Console.Write("Введите количество секунд, прошедших с начала суток: ");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());

            //int secondsInLastMinute = totalSeconds % 3600;

            //Console.WriteLine($"Количество секунд, прошедших с начала последнего часа: {secondsInLastMinute}");


            //27
            //Console.Write("Введите размер файла в байтах: ");
            //int byte = Convert.ToInt32(Console.ReadLine());

            //int Kb = byte / 1024;

            //Console.WriteLine($"Количество килобайтов: {Kb}");


            //28

            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());


            //int first = number / 100;

            //int reversedNumber = number % 100;


            //int result = reversedNumber * 10 + first;

            //Console.WriteLine($"Число: {result}");

            //29
            //Console.Write("Введите количество секунд, прошедших с начала суток: ");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());

            //int secondsInLastMinute = totalSeconds % 3600;
            //int minutes = secondsInLastMinute / 60;

            //Console.WriteLine($"Количество минут, прошедших с начала последнего часа: {minutes}");

            //30
            //Console.WriteLine("Введите два числа 1>2: ");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //if (numberOne > numberTwo)
            //{
            //    int result = numberOne / numberTwo;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("неправильно введены числа");
            //}

            //31
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());


            //int last = number % 10;

            //int reversedNumber = number / 10;


            //int result = last * 100 + reversedNumber;

            //Console.WriteLine($"Число: {result}");


            //32
            //Console.Write("Введите число от 1 до 365: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int dayOne = 1;

            //dayOne = (dayOne + number -1) % 7;
            //Console.Write($"Номер дня недели: {dayOne}");


            //33
            //Console.WriteLine("Введите два числа 1>2: ");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //if (numberOne > numberTwo)
            //{
            //    int result = numberOne % numberTwo;
            //    Console.WriteLine($"Результат: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("неправильно введены числа");
            //}


            //34
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 100 || number > 999)
            //{
            //    Console.WriteLine("Число должно быть трехзначным");
            //    return;
            //}
            //int first = number / 100;

            //int tens = (number / 10) % 10;

            //int units = number % 10;

            //int result = tens * 100 + first * 10 + units;

            //Console.WriteLine($"Число: {result}");


            //35
            //Console.Write("Введите число от 1 до 365: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int dayOne = 4;

            //dayOne = (dayOne + number - 1) % 7;
            //Console.Write($"Номер дня недели: {dayOne}");


            //36
            //Console.Write("Введите двухзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int first = number / 10;
            //int last = number % 10;
            //Console.WriteLine("Первое: " + first);
            //Console.WriteLine("Второе: " + last);

            //37
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 100 || number > 999)
            //{
            //    Console.WriteLine("Число должно быть трехзначным");
            //    return;
            //}
            //int first = number / 100;

            //int tens = (number / 10) % 10;

            //int units = number % 10;

            //int result = first * 100 + units * 10 + tens;

            //Console.WriteLine($"Число: {result}");


            //38
            //Console.Write("Введите число от 1 до 365: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int dayOne = 2;

            //dayOne = (dayOne + number) % 7;
            //Console.Write($"Номер дня недели: {dayOne}");


            //39
            //Console.Write("Введите двухзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int first = number / 10;
            //int last = number % 10;
            //Console.WriteLine("Сумма: " + (first + last));
            //Console.WriteLine("Произведение: " + (first * last));


            //40
            //Console.Write("Введите число больше 999: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 999)
            //{
            //    int first = (number / 100) % 10;

            //    Console.WriteLine("Первое: " + first);

            //}

            //41
            //Console.Write("Введите число от 1 до 365: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int dayOne = 6;

            //dayOne = (dayOne + number) % 7;
            //Console.Write($"Номер дня недели: {dayOne}");


            //42
            //Console.Write("Введите двухзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int tens = number / 10;
            //int one = number % 10;

            //int result = one * 10 + tens;

            //Console.WriteLine("Вывод: " + result);


            //43
            //Console.Write("Введите число больше 999: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 999)
            //{
            //    int first = (number / 1000) % 10;

            //    Console.WriteLine("Первое: " + first);

            //}

            //44
            //Console.Write("Введите число от 1 до 365: ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число от 1 до 7: ");
            //int n = Convert.ToInt32(Console.ReadLine());


            //int dayOne = (k + n) % 7;
            //Console.Write($"Номер дня недели: {dayOne}");



            //45
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = number / 100;
            //Console.WriteLine(result);


            //46
            //Console.Write("Введите количество секунд, прошедших с начала суток: ");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());

            //int min = totalSeconds / 60;

            //Console.WriteLine($"Количество минут, прошедших с начала последнего часа: {min}");


            //47
            //Console.WriteLine("Введите три числа A,B,C: ");
            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int C = Convert.ToInt32(Console.ReadLine());

            //int  numberOfSquares= (A / C) * (B / C);
            //int S = A * B - numberOfSquares * C * C;

            //Console.WriteLine($"Кол-во квадратов: numberOfSquares" );
            //Console.WriteLine($"Площадь: {S}");

            //48
            //Console.Write("Введите трехзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int one = (number % 10);
            //int two = (number / 10) % 10;
            //Console.WriteLine(one);
            //Console.WriteLine(two);


            //49
            //Console.Write("Введите количество секунд, прошедших с начала суток: ");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());

            //int has = totalSeconds / 3600;


            //Console.WriteLine($"Количество полных часов, прошедших с начала последнего часа: {has}");


            //50
            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());
            //int century = year / 100;

            //if (year % 100 != 0)
            //{
            //    century++;
            //}

            //Console.WriteLine($"Номер столетия: {century}");
        }
    }
   
    }


