/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня");

int a = Convert.ToInt32(Console.ReadLine());
if (a == 6|| a== 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}
if (a > 7||a <= 0 ) 
{
    Console.WriteLine("Ошибка, такого дня не существует");
}