﻿//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;

if(N>0)
     {
     while (i<=N) {
          System.Console.Write($" {i} ");
          i++;
          }
     }
else
     {
     while (i>=N) {
          System.Console.Write($" {i} ");
          i--;
          }   
     }