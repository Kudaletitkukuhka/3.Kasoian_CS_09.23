/* Напишите программу, которая по
заданному номеру четверти, показывает
диапазон возможных координат точек в этой
четверти (x и y). */

System.Console.WriteLine("Введите номер четверти (цифра от 1 до 4 включительно): ");
int N=Convert.ToInt32(Console.ReadLine());
if (N>4 || N<1) 
               {
                    System.Console.WriteLine("Вы ввели некорректное число");
               }
else {
     if (N==1)
               {
                    System.Console.WriteLine("x>0\ny>0");
               }
     if (N==2){
                    System.Console.WriteLine("x<0\ny>0");
              }
     if (N==3)
               {
                    System.Console.WriteLine("x<0\ny<0");
               }
     if (N==4){
                    System.Console.WriteLine("x>0\ny<0");
              }
     }