// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndInt(int row, int col)
{
    int size = 4;
    int count = 1;
    row = size;
    col = size;
    int[,] matrix = new int[row, col];    

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = count;
                count++;
                if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= matrix.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > matrix.GetLength(1) - 1)
                    j--;
                else
                    i--;        
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
int[,] matrix = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);