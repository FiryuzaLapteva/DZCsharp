// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] MyArray = new int [5,5];
//Заполняем периметр массива по часовой стрелке.
int s = 1;
{  
        for (int j = 0; j < MyArray.GetLength(1); j++) {
            MyArray[0,j] = s;
            s++;
        }
        for (int i = 1; i < 4; i++) {
            MyArray[i, MyArray.GetLength(1) - 1] = s;
            s++;
        }
        for (int j = MyArray.GetLength(0) - 2; j >= 0; j--) {
            MyArray[MyArray.GetLength(0) - 1, j] = s;
            s++;
        }
        for (int i = MyArray.GetLength(1) - 2; i > 0; i--) {
            MyArray[i,0] = s;
            s++;
        }
        //координаты новой ячейки
        int c = 1;
        int d = 1;
 
        while (s < MyArray.GetLength(0) * MyArray.GetLength(1)) {
            //В С# инициализированный интовый массив заполняется нулями.
            //Периметр мы заполнили числами, отличными от нулей.
            //Следующие циклы поочерёдно работают, заполняя ячейки.
            //Вложенный цикл останавливается, если следующая ячейка имеет 
            //значение, отличное от ноля. Ячейка, на которой остановился 
            //цикл, не заполняется.
 
            //Движемся вправо.
            while (MyArray[c,d + 1] == 0) {
                MyArray[c,d] = s;
                s++;
                d++;
            }
 
            //Движемся вниз.
            while (MyArray[c + 1,d] == 0) {
                MyArray[c,d] = s;
                s++;
                c++;
            }
 
            //Движемся влево.
            while (MyArray[c,d - 1] == 0) {
                MyArray[c,d] = s;
                s++;
                d--;
            }
 
            //Движемся вверх.
            while (MyArray[c - 1,d] == 0) {
                MyArray[c,d] = s;
                s++;
                c--;
            }
        }
        //При данном решении в центре всегда остаётся незаполненная ячейка.
        //Убираем её при помощи следующего цикла.
        for (int i = 0; i < MyArray.GetLength(0); i++) {
            for (int j = 0; j < MyArray.GetLength(1); j++) {
                if (MyArray[i,j] == 0) {
                    MyArray[i,j] = s;
                }
            }
        }
        //Выводим массив в консоль.
        for (int i = 0; i < MyArray.GetLength(0); i++) {
            for (int j = 0; j < MyArray.GetLength(1); j++) {
                if (MyArray[i,j] < 10) {
                    //Два пробела, чтобы в консоли столбцы были ровные.
                    Console.Write (MyArray[i,j] + ",  ");
                } else {
                    Console.Write (MyArray[i,j] + ", ");
                }
            }
          Console.WriteLine ();
        }
}


