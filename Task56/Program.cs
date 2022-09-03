// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");

        }
        Console.WriteLine("]");
    }
}

int[] SummElemArray(int[,] matrx)
{
    int[] arr = new int[matrx.GetLength(0)];
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrx.GetLength(1); j++)
        {

            sum += matrx[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int FindMinElem(int[] arr)
{
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex]) minIndex = i;
    }
    return minIndex;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] elemSumm = SummElemArray(matrix);
PrintArray(elemSumm);
int result = FindMinElem(elemSumm);
Console.WriteLine();
Console.WriteLine($"С наименьшей суммой элементов: {result + 1} строка");