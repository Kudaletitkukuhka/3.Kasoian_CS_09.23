/* : Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

/* System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N;i++) 
     {
     System.Console.Write($"{Math.Pow(i,3)}, ");
     }
System.Console.WriteLine("\b\b.");
 */

System.Console.Write("N = ");
int N=Convert.ToInt32(Console.ReadLine());

      for(int i=1;i<=N;i++) {
        System.Console.WriteLine($"{Math.Pow(i,3)}");
        }