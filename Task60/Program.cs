// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreateMatrixRndInt(int row, int col, int we, int min, int max)
{
    int[,,] matrix = new int[row, col, we];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j, k] = rnd.Next(min, max+1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i,j,k],4}({i},{j},{k})");
            }

        }
        // Console.WriteLine("]");
    }
}


int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(matrix);