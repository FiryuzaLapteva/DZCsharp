// ============Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[5];
int sum =0;
for(int i = 0; i<array.Length; i++)
{
    array[i]=new Random().Next(100,1000);
    if(i%2!=0)
    {
        sum+=array[i];
    }
}
 Console.WriteLine(String.Join( ";", array));
 Console.WriteLine("сумма элементов, стоящих на нечётных позициях = " + sum);
