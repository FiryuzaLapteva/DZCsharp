//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int number = 1; number <=N; number++)
{
    int result = (int) Math.Pow(number, 3);  
    Console.WriteLine(result);
}
