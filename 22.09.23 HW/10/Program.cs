/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
 */

Console.WriteLine("Введите трехзначное число: ");
int N=Convert.ToInt32(Console.ReadLine());
int num2=N%100/10;
     if (num2<0) {
                 num2=num2*(-1);   
                 }
System.Console.WriteLine($"Вторая цифра вашего числа {num2}");