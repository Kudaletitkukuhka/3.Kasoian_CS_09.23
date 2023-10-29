/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumBetweenNM(int from, int to)
{    
     if(from>to) return SumBetweenNM(to,from);
     if(from==to) return from;
     return from+SumBetweenNM(++from,to);
}


Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Сумма натуральных элеемнтов в промежутке между {M} и {N} равна {SumBetweenNM(M, N)}");
