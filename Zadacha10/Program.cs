//  Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int number1 = new Random().Next(100, 1000);
Console.WriteLine(number1);
int number2 = number1%100;
//Console.WriteLine(number2); 
int result = number2/10;

Console.WriteLine("Вторая цифра = "); 
Console.WriteLine(result);