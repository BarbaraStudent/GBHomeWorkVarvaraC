﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine ("Введите число");
String? number = Console.ReadLine();
int a = Convert.ToInt32(number);
int i=2;

Console.Write ($"Чётные числа от 1 до {a} : ");
if(a > 1)
{
    while(i <= a)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}

