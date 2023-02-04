/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
Console.WriteLine ("Введите число");
String? number = Console.ReadLine();
int a = Convert.ToInt32(number);
int b=(a  / 10) % 10;

if(a>999 || a<100)
{
    Console.WriteLine ("Это не трехзначное число!");
}
else {
Console.WriteLine($"Вторая цифра числа {a} - {b}");
}


