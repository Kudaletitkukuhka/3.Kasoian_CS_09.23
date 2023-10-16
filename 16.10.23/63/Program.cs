using System.Dynamic;
using System.Data;
using Internal;
using System;
/* 

Задача 63: Задайте значение N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
 
*/



void Print(int n)
{
     Console.Write($"{n} -> ");
     for (int i = 1; i <= n; i++)
     {
          System.Console.WriteLine($"{i} ");
     }
}

Print(N);
System.Console.WriteLine();

string PrintNumber(int start, int end)
{
     if(start == end) return Convert.ToString(start);
     return(start + " "+PrintNumber(start + 1, end));
}

System.Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{N} -> ");
