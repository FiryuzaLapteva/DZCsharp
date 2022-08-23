// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number1 = new Random().Next(10, 1000);
//int number1 = 72;
Console.WriteLine(number1);

if (number1 == 0 || number1 < 100)
{
    Console.WriteLine("Третьей цифры нет. ");
}
else
{
int number2 = (number1%100)%10;
Console.WriteLine(number2); 
}

