/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine ("Введите первое число");
String? number1 = Console.ReadLine();
Console.WriteLine ("Введите второе число");
int a = Convert.ToInt32(number1);
String? number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a>b)
{
    System.Console.WriteLine($"{a} больше {b}");
}
else
{
   if (a<b) 
   {
    System.Console.WriteLine($"{b} больше {a}");
   }
   else
   {
    System.Console.WriteLine("Числа равны");
   }
}
