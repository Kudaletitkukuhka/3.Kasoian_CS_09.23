/* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5  */

System.Console.WriteLine("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());

int Count(int N)
{
     int i=0;
     while(N>0)
     {
          N=N/10;
          i++;
     }
     return i;
}

int result=Count(A);
System.Console.WriteLine(result);