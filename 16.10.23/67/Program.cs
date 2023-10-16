/* 

Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 

*/

int SumNum(int N)
{
     if (N == 0) return N;
     return N%10+SumNum(N/10);
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N=SumNum(N);
System.Console.WriteLine(N);