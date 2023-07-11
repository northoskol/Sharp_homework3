// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Square(int value)
{
    for (int i = 1; i <= value; i++)
    {
        int square = i * i * i;
        Console.Write(square + " ");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int value = GetInput("Введите число: ");
Square(value);