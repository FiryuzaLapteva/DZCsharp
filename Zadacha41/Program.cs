// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



Console.Write("Введите количество элементов массива:" );
int sumElement = int.Parse(Console.ReadLine());
int[]array = new int[sumElement];// инициализируем массив с количеством элементов заданных пользователем.

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: \t ");
    array[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива");
Console.WriteLine(String.Join( ";", array));

int sumNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    sumNumbers+=1;
}
Console.WriteLine("количество числе больше нуля =" + sumNumbers);



