/* Напишите программу, которая будет принимать
на вход два числа и выводить, является ли второе
число кратным первому. Если число 2 не кратно числу
1, то программа выводит остаток от деления. */

Console.WriteLine("Введите первое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2=Convert.ToInt32(Console.ReadLine());

if (num2==0) {
                System.Console.WriteLine("На ноль делить нельзя");
             }

int ost=num1%num2;

if (num1%num2==0) {
                 System.Console.WriteLine("Кратно");
                 }
else {
     System.Console.WriteLine($"Некратно, {ost}");
     }