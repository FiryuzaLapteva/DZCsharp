// =============Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// =============которая покажет количество чётных 
int[] array = new int[4];
int sum =0;
for(int i = 0; i<array.Length; i++)
{
    array[i]=new Random().Next(100,1000);
    if(array[i]%2==0)
    {
        sum+=1; 
    }
}
     Console.WriteLine(String.Join( ";", array));
    Console.WriteLine("количество чётных чисел в массиве = " + sum);
