// Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно 
//на два без остатка).

Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());

if(N%2==0){
     System.Console.WriteLine($"{N} четное!");
}
else {
     System.Console.WriteLine($"{N} нечетное!");
}