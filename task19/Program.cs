﻿Console.Clear();
Console.Write("Введите значение для проверки: ");
string num = Console.ReadLine();

for (int i = 0; i < (num.Length/2); i++)
{
    if (num[i] != num[num.Length - 1 - i])
    {
        Console.WriteLine($"{num} - не палиндром");
        break;
    }
Console.Clear();
Console.WriteLine($"{num} - палиндром");
}