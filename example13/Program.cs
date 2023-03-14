// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();

int n= new Random().Next(1,100000); 
    Console.WriteLine($"Random {n}");

if (n < 100)
    Console.WriteLine(" нету 3 цифры");
else if (10000<n)
    Console.WriteLine($"{n/100 % 10}");    
else if (1000<n)
    Console.WriteLine($"{n/10 % 10}");

else 
    Console.WriteLine($" {n % 10}");

