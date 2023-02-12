/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите первое число");
String? number1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
String? number2 = Console.ReadLine();
int a = Convert.ToInt32(number1);
int b = Convert.ToInt32(number2);

double res = 1;
for (int i = 1; i <= b; i++)
{
    res = res * a;
}
Console.WriteLine($"{a} в степени {b} равна {res}");