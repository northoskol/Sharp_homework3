// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
    return distance;
}
double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double x1 = GetInput("Введите координаты X1: ");
double y1 = GetInput("Введите координаты y1: ");
double z1 = GetInput("Введите координаты z1: ");
double x2 = GetInput("Введите координаты x2: ");
double y2 = GetInput("Введите координаты y2: ");
double z2 = GetInput("Введите координаты z2: ");
CalculateDistance(x1, y1, z1, x2, y2, z2);
Console.Write("Ответ: " + CalculateDistance(x1, y1, z1, x2, y2, z2));