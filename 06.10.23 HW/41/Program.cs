/* Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

System.Console.WriteLine("Введите количество чисел: ");
int M=Convert.ToInt32(Console.ReadLine());
int result=0;

int[] array = new int[M];

for (int i = 0; i < M; i++)
{
     System.Console.Write("Введите число: ");
     array[i]=Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < M; i++)
{
     if(array[i]>0) result++;
}

System.Console.Write($"Среди ваших чисел {result} больше 0.");