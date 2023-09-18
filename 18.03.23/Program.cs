/*System.Console.WriteLine("Введите первое число:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int b=Convert.ToInt32(Console.ReadLine());
if(a==b*b){
     System.Console.WriteLine($"Ура! {a} является квадратом числа {b}");
}
else {
     System.Console.WriteLine($"Упс! {a} не является квадратом числа {b}");
}*/


/*
Задача №5. Напишите программу, 
которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в 
промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int num=N*(-1);

/*if(N>0){
     while(num<=N){
     Console.Write($" {num} ");
     num++;
     //num=num+1;
     }
}

else{
     while(num>=N){
     Console.Write($" {num} ");
     num--;
     //num=num-1;
     }
}
*/


//Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


/*System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int ostatok=N%10;
System.Console.WriteLine(ostatok);
*/

