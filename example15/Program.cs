// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine($"Vvod day week: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1 && n < 6)

{
    Console.WriteLine("Будний день иди работать");
}
else if (n>5 && n<8)
        Console.WriteLine("Выходной");
else
    Console.WriteLine("набери с 1 по 7 день");
