// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 5;
int N = 7;
 int Summa (int M, int N)
 {
    if (M == N) return M;
    return (M + Summa(M + 1, N));
 }
 Console.WriteLine(Summa(M,N));
 Console.WriteLine();
