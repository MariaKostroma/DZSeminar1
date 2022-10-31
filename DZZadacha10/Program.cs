// Задача10 Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100 || num>999)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    int num12 = num / 10;
    int num2 = num12 % 10;
    Console.WriteLine($"Вторая цифра: {num2}");
}
