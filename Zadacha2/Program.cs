//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int number1 = new Random().Next(1, 10);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);



int max = number1;

if (max < number2 || max == number2) max = number2;
else
{
    max = number1;
}
Console.WriteLine(max);
