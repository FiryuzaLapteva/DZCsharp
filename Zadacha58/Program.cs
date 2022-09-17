// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] arrayOne = new int [3,3];

for (int i = 0; i < arrayOne.GetLength(0); i++)
{
    for (int j = 0; j < arrayOne.GetLength(1); j++)
    {
        arrayOne[i,j] = new Random().Next (-10,10);
        Console.Write(arrayOne [i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int [,] arrayTwo = new int [3,3];

for (int i = 0; i < arrayTwo.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
    {
        arrayTwo[i,j] = new Random().Next (-10,10);
        Console.Write(arrayTwo [i,j] + "\t");
    } 
    Console.WriteLine();
}
Console.WriteLine("Произведение матриц: ");

//Создаем новый двумерный массив с размерами массив, котрые будут использованы.
int [,] Multiplication = new int [arrayOne.GetLength(0), arrayTwo.GetLength(1)];
{

    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                Multiplication[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
            Console.Write(Multiplication[i, j] + "\t");
        }

        Console.WriteLine();
    }
}