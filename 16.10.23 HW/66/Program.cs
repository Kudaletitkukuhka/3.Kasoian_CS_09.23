/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int SumBetweenNM(int M, int N)
{    
     if(M==N) return M;
     else if(M < N)
     {
          return M+=SumBetweenNM(M++,N);
     }
     else 
     {
          System.Console.WriteLine("Ошибка");
          return 0;
     }
}

Console.Write("Введите начало периода: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите крайнее значение периода: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumBetweenNM(M, N));
