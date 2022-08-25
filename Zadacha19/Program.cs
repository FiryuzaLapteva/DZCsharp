// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

int number1 = new Random().Next(1000, 100000);
Console.WriteLine(number1);
string s1 = number1.ToString();

if(s1[0] == s1 [4] && s1 [1]== s1 [3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}