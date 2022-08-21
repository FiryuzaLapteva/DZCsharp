//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1 = new Random().Next(1, 100);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 100);
Console.WriteLine(number2);
int number3 = new Random().Next(1, 100);
Console.WriteLine(number3);

int max = number1;

if (max < number2 || max == number2) max = number2;
if (max < number3 || max == number3) max = number3;
else
{
    max = number1;
}
Console.WriteLine(max);
