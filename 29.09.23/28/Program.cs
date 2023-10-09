/* : Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

System.Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int Multiply(int N)
{
     int multiply=1;
     for (int i = 1; i <= N; i++)
     {
          multiply=multiply*i;
     }
     return multiply;
}

int result=Multiply(N);
System.Console.WriteLine(result);