Console.Clear();

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

    if(a * a == b)
        Console.WriteLine("yes");
    else
{
    if(b * b == a)
    Console.WriteLine("yes");
    else 
    Console.WriteLine("no");
}       

