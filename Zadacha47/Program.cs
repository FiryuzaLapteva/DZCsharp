// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


double[,] matrix = new double[rows,columns];
Random rand = new Random();
for(int i=0; i<rows; i++)
{
	for(int j=0; j<columns; j++)
	{
    matrix[i, j] = Math.Round((rand.NextDouble() * rand.Next(-9,10)),2);
		Console.Write (matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
