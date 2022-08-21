// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x < N +1; x++)
if (x%2 ==0)
Console.WriteLine (x);


