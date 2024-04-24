using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //1
        //Console.Write("Введите число: ");
        //int number = int.Parse(Console.ReadLine());

        //if (number > 0)
        //    Console.WriteLine("Число положительное");
        //else if (number < 0)
        //    Console.WriteLine("Число отрицательное");
        //else
        //    Console.WriteLine("Число равно нулю");

        //2
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //    Console.WriteLine("Год високосный");
        //else
        //    Console.WriteLine("Год не високосный");

        //3
        //Console.Write("Введите символ: ");
        //char symbol = char.ToLower(Console.ReadKey().KeyChar);

        //if (char.IsLetter(symbol))
        //{
        //    if ("mami".Contains(symbol))
        //        Console.WriteLine("\nГласная буква");
        //    else
        //        Console.WriteLine("\nСогласная буква");
        //}
        //else
        //{
        //    Console.WriteLine("\nЭто не буква");
        //}

        //4
        //Console.WriteLine("Введите три числа:");
        //int num1 = int.Parse(Console.ReadLine());
        //int num2 = int.Parse(Console.ReadLine());
        //int num3 = int.Parse(Console.ReadLine());

        //int min = num1;

        //if (num2 < min)
        //    min = num2;
        //if (num3 < min)
        //    min = num3;

        //Console.WriteLine("Наименьшее число: " + min);

        //5
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //if (year % 100 == 0)
        //    Console.WriteLine("Год является вековым");
        //else
        //    Console.WriteLine("Год не является вековым");

        //6
        //Console.Write("Введите число: ");
        //int number = int.Parse(Console.ReadLine());

        //if (number >= 10 && number <= 20)
        //    Console.WriteLine("Число принадлежит диапазону от 10 до 20");
        //else
        //    Console.WriteLine("Число не принадлежит диапазону от 10 до 20");

        //7
        //Console.Write("Введите символ: ");
        //char symbol = Console.ReadKey().KeyChar;

        //if (char.IsDigit(symbol))
        //    Console.WriteLine("\nЭто цифра");
        //else if (char.IsLetter(symbol))
        //    Console.WriteLine("\nЭто буква");
        //else
        //    Console.WriteLine("\nЭто специальный символ");

        //8
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());

        //switch (month)
        //{
        //    case 12:
        //    case 1:
        //    case 2:
        //        Console.WriteLine("Зима");
        //        break;
        //    case 3:
        //    case 4:
        //    case 5:
        //        Console.WriteLine("Весна");
        //        break;
        //    case 6:
        //    case 7:
        //    case 8:
        //        Console.WriteLine("Лето");
        //        break;
        //    case 9:
        //    case 10:
        //    case 11:
        //        Console.WriteLine("Осень");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        break;
        //}

        //9
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //if (year >= 1901 && year <= 2000)
        //    Console.WriteLine("Год принадлежит XX веку");
        //else if (year >= 2001 && year <= 2100)
        //    Console.WriteLine("Год принадлежит XXI веку");
        //else
        //    Console.WriteLine("Год не принадлежит ни XX, ни XXI веку");

        //10
        //Console.Write("Введите число: ");
        //int number = int.Parse(Console.ReadLine());

        //if (number % 2 == 0)
        //    Console.WriteLine("Число четное");
        //else
        //    Console.WriteLine("Число нечетное");

        //11
        //Console.Write("Введите символ: ");
        //char symbol = Console.ReadKey().KeyChar;

        //if (char.IsLower(symbol))
        //    Console.WriteLine("\nСтрочная буква");
        //else if (char.IsUpper(symbol))
        //    Console.WriteLine("\nЗаглавная буква");
        //else
        //    Console.WriteLine("\nЭто не буква");

        //12
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());

        //switch (month)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        Console.WriteLine("Первый квартал");
        //        break;
        //    case 4:
        //    case 5:
        //    case 6:
        //        Console.WriteLine("Второй квартал");
        //        break;
        //    case 7:
        //    case 8:
        //    case 9:
        //        Console.WriteLine("Третий квартал");
        //        break;
        //    case 10:
        //    case 11:
        //    case 12:
        //        Console.WriteLine("Четвертый квартал");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        break;
        //}

        //13
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //int days;

        //switch (month)
        //{
        //    case 1:
        //    case 3:
        //    case 5:
        //    case 7:
        //    case 8:
        //    case 10:
        //    case 12:
        //        days = 31;
        //        break;
        //    case 4:
        //    case 6:
        //    case 9:
        //    case 11:
        //        days = 30;
        //        break;
        //    case 2:
        //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //            days = 29;
        //        else
        //            days = 28;
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        return;
        //}

        //Console.WriteLine($"В месяце {month} {year} года {days} дней");

        //14
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());

        //switch (month)
        //{
        //    case 1:
        //        Console.WriteLine("Январь");
        //        break;
        //    case 2:
        //        Console.WriteLine("Февраль");
        //        break;
        //    case 3:
        //        Console.WriteLine("Март");
        //        break;
        //    case 4:
        //        Console.WriteLine("Апрель");
        //        break;
        //    case 5:
        //        Console.WriteLine("Май");
        //        break;
        //    case 6:
        //        Console.WriteLine("Июнь");
        //        break;
        //    case 7:
        //        Console.WriteLine("Июль");
        //        break;
        //    case 8:
        //        Console.WriteLine("Август");
        //        break;
        //    case 9:
        //        Console.WriteLine("Сентябрь");
        //        break;
        //    case 10:
        //        Console.WriteLine("Октябрь");
        //        break;
        //    case 11:
        //        Console.WriteLine("Ноябрь");
        //        break;
        //    case 12:
        //        Console.WriteLine("Декабрь");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        break;
        //}

        //15
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());

        //switch (month)
        //{
        //    case 1:
        //    case 2:
        //    case 12:
        //        Console.WriteLine("Зима");
        //        break;
        //    case 3:
        //    case 4:
        //    case 5:
        //        Console.WriteLine("Весна");
        //        break;
        //    case 6:
        //    case 7:
        //    case 8:
        //        Console.WriteLine("Лето");
        //        break;
        //    case 9:
        //    case 10:
        //    case 11:
        //        Console.WriteLine("Осень");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        break;
        //}

        //16
        //Console.Write("Введите номер дня недели (от 1 до 7): ");
        //int day = int.Parse(Console.ReadLine());

        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Понедельник");
        //        break;
        //    case 2:
        //        Console.WriteLine("Вторник");
        //        break;
        //    case 3:
        //        Console.WriteLine("Среда");
        //        break;
        //    case 4:
        //        Console.WriteLine("Четверг");
        //        break;
        //    case 5:
        //        Console.WriteLine("Пятница");
        //        break;
        //    case 6:
        //        Console.WriteLine("Суббота");
        //        break;
        //    case 7:
        //        Console.WriteLine("Воскресенье");
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер дня недели");
        //        break;
        //}


        //17
        //Console.Write("Введите день: ");
        //int day = int.Parse(Console.ReadLine());
        //Console.Write("Введите месяц: ");
        //int month = int.Parse(Console.ReadLine());
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //DateTime date = new DateTime(year, month, day);
        //DayOfWeek dayOfWeek = date.DayOfWeek;

        //switch (dayOfWeek)
        //{
        //    case DayOfWeek.Monday:
        //        Console.WriteLine("Понедельник");
        //        break;
        //    case DayOfWeek.Tuesday:
        //        Console.WriteLine("Вторник");
        //        break;
        //    case DayOfWeek.Wednesday:
        //        Console.WriteLine("Среда");
        //        break;
        //    case DayOfWeek.Thursday:
        //        Console.WriteLine("Четверг");
        //        break;
        //    case DayOfWeek.Friday:
        //        Console.WriteLine("Пятница");
        //        break;
        //    case DayOfWeek.Saturday:
        //        Console.WriteLine("Суббота");
        //        break;
        //    case DayOfWeek.Sunday:
        //        Console.WriteLine("Воскресенье");
        //        break;
        //}

        //18
        //Console.Write("Введите номер месяца: ");
        //int month = int.Parse(Console.ReadLine());
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //int days;

        //if (month < 1 || month > 12)
        //{
        //    Console.WriteLine("Некорректный номер месяца");
        //    return;
        //}

        //switch (month)
        //{
        //    case 1:
        //    case 3:
        //    case 5:
        //    case 7:
        //    case 8:
        //    case 10:
        //    case 12:
        //        days = 31;
        //        break;
        //    case 4:
        //    case 6:
        //    case 9:
        //    case 11:
        //        days = 30;
        //        break;
        //    case 2:
        //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        //            days = 29;
        //        else
        //            days = 28;
        //        break;
        //    default:
        //        Console.WriteLine("Некорректный номер месяца");
        //        return;
        //}

        //Console.WriteLine($"В месяце {month} {year} года {days} дней");

        //19
        //Console.Write("Введите время суток (0-24): ");
        //int time = int.Parse(Console.ReadLine());

        //string partOfDay;

        //if (time >= 0 && time < 6)
        //    partOfDay = "ночь";
        //else if (time >= 6 && time < 12)
        //    partOfDay = "утро";
        //else if (time >= 12 && time < 18)
        //    partOfDay = "день";
        //else
        //    partOfDay = "вечер";

        //Console.WriteLine($"Время суток: {partOfDay}");

        //20
        //Console.Write("Введите год: ");
        //int year = int.Parse(Console.ReadLine());

        //if (year % 100 == 0)
        //    Console.WriteLine("Год является вековым");
        //else
        //    Console.WriteLine("Год не является вековым");
    }
}