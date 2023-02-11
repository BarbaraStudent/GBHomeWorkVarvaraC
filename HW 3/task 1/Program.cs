/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да */

int InPutInt(string msg)
{
    Console.WriteLine(msg);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InPutInt("Введите число");
if (a >= 10000)
{
    int ReverseDigit(int a)
    {
        int rev = 0;
        while (a > 0)
        {
            rev = rev * 10 + a % 10;
            a = a / 10;
        }
        return rev;
    }

    Console.WriteLine($"Число {a} является палиндромом");
}
else
    Console.WriteLine("Число не пятизначное!");