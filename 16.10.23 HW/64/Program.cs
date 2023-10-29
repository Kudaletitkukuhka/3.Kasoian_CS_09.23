/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

void PrintTillN(int N)
{

     if(N==1)
     {
          System.Console.WriteLine(N);
     }
     else if(N<1)
     {
          System.Console.WriteLine("вы ввели число меньше 1. Попробуйте еще раз");
     }
     else
     {
          Console.Write($"{N}\t");
          PrintTillN(N-1);
     }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintTillN(N);
