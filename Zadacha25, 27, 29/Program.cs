// =================Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int A = new Random ().Next(0,10);
int B = new Random().Next(0,10);
Console.WriteLine($"{A}, {B}");
Console.WriteLine(GetProduct(A, B));

 int GetProduct(int A, int B)
{
    int prod = 1;
    for(int i = 1; i <= B; i++)
    {
        prod*=A;
    }

    return prod;
}

// ===============Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int number = new Random ().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine("Cумма цифр в числе = " + Foo(number));


int Foo(int number)
{
    int result = 0;
    while(number>0)
    {
        result+=number%10;
        number = number/10;
    }
    return result;
}

//===============29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i<array.Length; i++)
{
    array[i]= rand.Next(-100, 100);
}

void PrintArray(int[] col) {
	int count = col.Length;
	int position = 0;
	while (position < count) {
		Console.Write(col[position] + ", ");
		position++;
	}
}

PrintArray(array);