/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int InPutInt(string msg)
{
    Console.WriteLine(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InPutInt("Введите число");
int c = a % 10;
int b = (a / 10) % 10;
System.Console.WriteLine(c);
System.Console.WriteLine(b);


if (a < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа {a} - {c}");
}


