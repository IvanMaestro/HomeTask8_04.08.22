// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultMatrix(int[,] first, int[,] second)
{
    int[,] temp = new int[first.GetLength(0), second.GetLength(1)];
    if (first.GetLength(1) == second.GetLength(0))
    {        
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < second.GetLength(1); j++)
            {
                for (int k = 0; k < second.GetLength(0); k++)
                {
                    temp[i, j] += first[i, k] * second[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Матрицы не могут быть перемножены");        
    }
    return temp;
}

int[,] firstMatrix = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] multiMatrix = MultMatrix(firstMatrix, secondMatrix);
PrintMatrix(multiMatrix);
