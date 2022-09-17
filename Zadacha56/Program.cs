// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int [,] array = new int [3,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next (-10,10);
        Console.Write(array [i,j] + "\t");
    }
    Console.WriteLine();
}

int[] res1 = new int[array.GetLength(0)];
{   
    int summa = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summa=0;
       for (int j = 1; j < array.GetLength(1); j++)
       {
        summa+=array[i,j];
        }
        res1[i]=summa;
      Console.Write(summa + "\t");
    }
    
 Console.WriteLine();
}
int min = 0;    //индекс строки с минимальной суммой
    for (int j = 1; j < array.GetLength(0); j++)
        {
        if (res1[j] < res1[min]) 
        {
            min = j;//если есть строка с суммой меньше, то пишем в min её индекс
        }  
        }
    min = min +1;
          Console.WriteLine("Номер строки с минимальной суммой элементов: "+ min); 
        