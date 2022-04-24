// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Урок 1 практика 1 /*

/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            1) a = 5; b = 7 -> max = 7; 2) a = 2 b = 10 -> max = 10; 3) a = -9 b = -3 -> max = -3
*/
/*
// 1) a = 5; b = 7 -> max = 7
int a = 5, b = 7, max = 0;
if (a > b) max = a;
else max = b;
Console.WriteLine("max = " + max);
*/
/*
// 2) a = 2 b = 10 -> max = 10
int a = 2, b = 10, max = 0;
if (a > b) max = a;
else max = b;
Console.WriteLine("max = " + max);
*/
/*
// 3) a = -9 b = -3 -> max = -3
int a = -9, b = -3, max = 0;
if (a > b) max = a;
else max = b;
Console.WriteLine("max = " + max);
*/
/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            1) 2, 3, 7 -> 7; 2) 44 5 78 -> 78; 3) 22 3 9 -> 22
*/
/*
// 1) 2, 3, 7 -> 7
int a = 2, b = 3, c = 7, max = 0;
if (a > b & b > c) max = a;
else 
if (b > c) max = b;
else max = c;
Console.WriteLine("max = " + max);
*/
/*
// 2) 44, 5, 78 -> 78
int a = 44, b = 5, c = 78, max = 0;
if (a > b & a > c) max = a;
else 
if (b > c) max = b;
else max = c;
Console.WriteLine("max = " + max);
*/
/*
// 3) 22, 3, 9 -> 22
int a = 22, b = 3, c = 9, max = 0;
if (a > b & a > c) max = a;
else 
if (b > c) max = b;
else max = c;
Console.WriteLine("max = " + max);
*/
/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            1) 4 -> да; 2) -3 -> нет; 3) 7 -> нет
*/
/*
// 1) 4 -> да
int a = 4, b = 2;
double result = a % b;
if (result == 0) 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является чётным");
}
else 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является нечётным");
}
*/
/*
// 2) -3 -> нет
int a = -3, b = 2;
double result = a % b;
if (result == 0) 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является чётным");
}
else 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является нечётным");
}
*/
/*
// 2) 7 -> нет
int a = 7, b = 2;
double result = a % b;
if (result == 0) 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является чётным");
}
else 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является нечётным");
}
*/
/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            1) 5 -> 2, 4; 2) 8 -> 2, 4, 6, 8
*/
/*
// 1) 5 -> 2, 4
int a = 5, b = 2;
double result = a % b;
if (result == 0) 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является чётным");
}
else 
{
    result = a / b;
    Console.WriteLine("result = " + result + " Число является нечётным");
}
*/

