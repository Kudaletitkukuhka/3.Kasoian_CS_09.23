/* Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23. */

Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

if   (N%7==0 && N%23==0)   {
          System.Console.WriteLine("да");
          }
          else
          {
               System.Console.WriteLine("нет");
          }