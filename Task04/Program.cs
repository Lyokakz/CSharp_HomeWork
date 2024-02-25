/*
Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
*/

Console.WriteLine("Введите натуральное число N:");
int number = Convert.ToInt32(Console.ReadLine());

string digits = "";
int newNumber = number;

while (newNumber > 0)
{
    int digit = newNumber % 10;
    digits = digit + (digits == "" ? "" : ",") + digits;
    newNumber /= 10;
}

Console.WriteLine($"{number} => {digits}");



