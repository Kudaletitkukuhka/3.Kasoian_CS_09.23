/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */


System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N;i++) 
     {
     System.Console.Write($"{i*i}, ");
     }
System.Console.WriteLine("\b\b.");

/* 
2 вариант
System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N;i++) 
     {
     System.Console.Write($"{i}  ");
     System.Console.WriteLine(i*i);
     }*/
