// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
//  двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив");

int [,] matrix = new int[rows, columns];
for (int i = 1; i < rows; i++)
{
    for (int j = 1; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(-100,100);//заполняем массив случайными числами
        Console.Write(matrix[i, j] +"\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки ");
int UserRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int UserColums = Convert.ToInt32(Console.ReadLine());

if (UserRows > matrix.GetLength(0) 
    || UserColums > matrix.GetLength(1)
    || UserRows < 1
    || UserColums < 1)
{
Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Элемент в заданной ячейке = " + matrix[UserRows,UserColums]);

}

