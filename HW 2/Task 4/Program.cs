/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета. */

int a = new Random().Next(100, 999);
Console.WriteLine($"Удаляем вторую цифру в числе {a}");
int b = a / 100 * 10 + a % 10;
System.Console.WriteLine(b);