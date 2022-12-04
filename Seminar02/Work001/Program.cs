// Напишите программу, которая выводит 
//случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8


Console.Clear();

int number = new Random(). Next(10, 100);     // (10, 99)
Console.WriteLine($"Сгенерированное число: {number}");
int n1 = number / 10;
int n2 = number % 10;
    if (n1 > n2)
        Console.WriteLine(n1);
    else
        Console.WriteLine(n2);


//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n % m == 0)
   // Console.WriteLine("Кратно");
//else
    //Console.WriteLine($"Не кратно, остаток {n % m}");

