﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number from 1 to 7");
int num=int.Parse(Console.ReadLine());
if (num==6 || num==7) Console.WriteLine("Yes");
    else if(num>7) Console.WriteLine("Incorrect number");
        else Console.WriteLine("No");