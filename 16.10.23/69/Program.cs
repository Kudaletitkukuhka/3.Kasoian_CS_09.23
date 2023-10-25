/* 
Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с 
помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int PowNum(int a, int b)
{
     if (b==0) return 1;
     else if (b==1) return a;
     else
     {
          return a*PowNum(a,b-1);
     }
}

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{A} в степени {B} равно {PowNum(A,B)}");