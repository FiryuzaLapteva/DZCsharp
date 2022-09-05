// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[5];// Инициируем массив размером 5 элементов
for(int i = 0; i<array.Length; i++)
{ 
    array[i]=new Random().Next(-100,100);
}
 Console.WriteLine(String.Join( ";", array));

int NumberMax (int[] num){ //Ищем максимальное число в массиве
int max = num[0];
for (int j = 1; j < num.Length; j++)
{
    if (max < num[j])
    { 
        max = num [j];
    }
}
return max;
}
Console.WriteLine(NumberMax(array));

int NumberMin (int[] num){ //Ищем минимальное число в массиве
int min = num[0];
for (int j = 1; j < num.Length; j++)
{
    if (min > num[j])
    { 
        min = num [j];
    }
}
return min;
}
Console.WriteLine(NumberMin(array));

Console.WriteLine("Максимальное - Минимальное = " + (NumberMax(array) - NumberMin(array)));
