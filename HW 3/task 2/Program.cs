/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите посследовательность координат: ");
int InPutInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int xA = InPutInt("Введите координату X точки A: ");
int yA = InPutInt("Введите координату Y точки A: ");
int zA = InPutInt("Введите координату Z точки A: ");
int xB = InPutInt("Введите координату X точки B: ");
int yB = InPutInt("Введите координату Y точки B: ");
int zB = InPutInt("Введите координату Z точки B: ");

Console.Write($"Координаты точки А: {xA};{yA};{zA} и Координаты точки B: {xB};{yB};{zB} .");

double a = xA - xB;
double b = yA - yB;
double c = zA - zB;
double result = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($" Длинна отрезка {result}");

