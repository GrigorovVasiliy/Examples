﻿
Console.Clear();

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

    if(a % b == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine($"Не кратно, остаток {a % b}");
