﻿using System.Runtime.CompilerServices;

double a;
double b;
char d;
double total;
char oper;
d = 'N';

while (d != 'Y')
{
    Console.WriteLine("Приветствую вас, маленькие любители экстримизма.");
    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
    }

    else if (oper == '/')
    {
        if (b == 0)
            Console.WriteLine("Деление на ноль невозможно");
        else
        {
            total = a / b;
            Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
        }
    }
    else
    {
        Console.WriteLine("Неизвестный оператор.");
    }
    Console.WriteLine("Хотите завершить работу приложения(Y/N)?");
    d = Convert.ToChar(Console.ReadLine());
}
