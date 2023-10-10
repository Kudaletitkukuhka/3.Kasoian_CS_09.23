/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

 int exp=1;

System.Console.WriteLine("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень в которую мы возводим число: ");
int B=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= B; i++)
{
     exp=exp*A;
}

System.Console.WriteLine($"Число {A} в степени {B} равно {exp}");