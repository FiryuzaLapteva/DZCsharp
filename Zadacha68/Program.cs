// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> Akkerman(m,n) = 9
// m = 3, n = 2 -> Akkerman(m,n) = 29

// функция Аккермана
int n = 1;
int m = 2;
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.WriteLine(Akkerman(n,m));