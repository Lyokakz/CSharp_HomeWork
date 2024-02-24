/*
Задача 2: Напишите программу, которая принимает
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.
*/

Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write($"{x}, {y} => 1");
}
else if (x < 0 && y > 0)
{
    Console.Write($"{x}, {y} => 2");
}
else if (x < 0 && y < 0)
{
    Console.Write($"{x}, {y} => 3");
}
else if (x > 0 && y < 0)
{
    Console.Write($"{x}, {y} => 4");
}
else
{
    Console.WriteLine("Ошибка ввода координат");
}

