/* Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

System.Console.WriteLine("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());

int Sum(int limit)
{
     int sum = 0;
     for ( int i = 1; i <= limit; i++)
          {
               sum+=i;
          }          
     return sum;
}

int result=Sum(A);
System.Console.WriteLine($"Сумма чисел от 1 до {A} равна {result}");