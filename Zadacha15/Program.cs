// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7.");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет"); 
}