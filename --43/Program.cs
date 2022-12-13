//Задача 43: Напишите программу, которая найдёт точку пересечения двух
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1,
// b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

void FindXY (double a1, double c1, double a2, double c2)
{
    double x = (a2-a1)/(c1-c2);
    double y = c1*x+a1; 
    Console.WriteLine($"Координата х= {x}");
    Console.WriteLine($"Координата у= {y}");
}

FindXY(b1,k1,b2,k2);


