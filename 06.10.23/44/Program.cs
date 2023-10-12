/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

int[] array = new int [N];

if (N>=2)
{
     array[0] = 0;
     array[1] = 1;

     for (int i = 2; i < N; i++)
     {
          array[i] = array[i-2] + array[i-1];
     }

     for (int i = 0; i < N; i++)
     {
          System.Console.Write($"{array[i]}\t");
     }
}

if (N==0) System.Console.WriteLine("Попробуйте ввести число больше 0");
if (N==1) System.Console.WriteLine("0");
