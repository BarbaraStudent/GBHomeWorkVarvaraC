/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int InPutInt(string msg)
{
    Console.WriteLine(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InPutInt("Введите число");
int sum = 0;
while (a > 0)
{
    int digit = a % 10;
    sum = sum + digit;
    a = a / 10;
}
System.Console.Write($"Сумма цифр числа равна {sum}");
