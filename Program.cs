﻿// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100,1000);
// Console.WriteLine (number);
// int second = (number /10) % 10;
// Console.WriteLine (second);

//--------------------------------------------------------

// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(10,1000);
Console.WriteLine (number);
int second = 0;

if (number >= 1000)
{
    second = number /100;
    int div10 = second % 10;
    Console.WriteLine (div10);
}
else
{
    if ((number / 10) < 9)
        {
            Console.WriteLine ("третьей цифры нет");
        }
        else
        {
            second = number % 10;
            Console.WriteLine (second);
        }
}
    



//--------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// int number = new Random().Next(1,8);
// Console.WriteLine (number);

// if ((number == 6) || (number==7))
// {
//     Console.WriteLine ("Выходной");
// }
// else
// {
//   Console.WriteLine ("Будни"); 
// }