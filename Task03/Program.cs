/*
 Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
 показывает наибольшую цифру числа.
 */


Console.WriteLine("Введите целое число из отрезка [10, 99]");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10; // получаем первую цифру
    int secondDigit = num % 10; // получаем вторую цифру

    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"{num} => {firstDigit}");
    }
    else if (firstDigit < secondDigit)
    {
        Console.WriteLine($"{num} => {secondDigit}");
    }
    else
    {
        Console.WriteLine($"{num} => Цифры равны");
    }
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
