/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N<0) 
{
     N=N*(-1);
}

int Count(int n)
{
     int count=0;
     while (n >= 1)
     {
          count=count+n%10;
          n=n/10;
     }
     return count;
}

System.Console.WriteLine(Count(N));