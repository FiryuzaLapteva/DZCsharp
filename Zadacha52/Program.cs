// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив из целых чисел");

int [,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(-10,10);//заполняем массив случайными целыми числами
        Console.Write(matrix[i, j] +"\t");
    }
    Console.WriteLine();
}
    double average;// Вводим переменную среднее арифметическое типа Double
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   double summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa+= matrix[i,j];
        }
         average = summa/ matrix.GetLength(0);
        Console.Write(average + ";");
    }
     Console.WriteLine();

