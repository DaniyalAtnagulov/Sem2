// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Enter the three-digit number");
int num=int.Parse(Console.ReadLine());
int num1=num/10;
int SecondNum=num1%10;
Console.WriteLine($"The second digit of the {num} is-> {SecondNum}");