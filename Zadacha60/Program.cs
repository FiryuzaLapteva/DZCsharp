// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int [,,] arrayOne = new int [3,3,3];
// Проверка условия достаточности двузначных чисел
if (arrayOne.GetLength(0) * arrayOne.GetLength(1) * arrayOne.GetLength(2) > 90)      
{
    Console.WriteLine("НЕДОСТАТОЧНО УНИКАЛЬНЫХ ДВУЗНАЧНЫХ ЧИСЕЛ ДЛЯ ЗАПОЛНЕНИЯ МАССИВА");
}
else
{
    // Задаем вспомогательный массив из двузначных элементов по порядку
    // и затем тасуем элементы внутри него
    
    int[] arrayRandom = new int[90];
    for (int i = 0; i < arrayRandom.Length-1; i++)
    {
        arrayRandom[i] = 10 + i;
    }
    int temp;
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        int j = new Random().Next(arrayRandom.Length);
        temp = arrayRandom[j];
        arrayRandom[j] = arrayRandom[i];
        arrayRandom[i] = temp;
    }


int count =0;
for (int i = 0; i < arrayOne.GetLength(0); i++)
{
    for (int j = 0; j < arrayOne.GetLength(1); j++)
    {
        for (int k = 0; k < arrayOne.GetLength(2); k++)
        {
        
        arrayOne[i,j,k] = arrayRandom [count];
        Console.Write(($"{arrayOne[i, j, k]}({i},{j},{k}) "));
        count += 1;
        }
    }
    Console.WriteLine();
}
}

    