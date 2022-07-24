//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//в задании сказано по убыванию, но пример вывода дан по возрастанию. Сделал как в примере вывода

int[,] matrix = FillMatrixRandomly();

Console.WriteLine("Original matrix");
PrintMatrix(matrix);

SortMatrixRows(matrix);
Console.WriteLine("Sorted Matrix");
PrintMatrix(matrix);

void SortMatrixRows(int[,] matrix)
{
    int[,] sortedMatrix = matrix;
    for (int row = 0; row < sortedMatrix.GetLength(0); row++)
    {
        //пузырьком
        int max = sortedMatrix[row, 0];
        int buffer = 0;
        for (int i = matrix.GetLength(1) - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (matrix[row, j + 1] < matrix[row, j])
                {
                    buffer = matrix[row, j];
                    matrix[row, j] = matrix[row, j + 1];
                    matrix[row, j + 1] = buffer;
                }
            }
        }
    }
}

void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillMatrixRandomly()
{
    int minDimensionLength = 5;
    int maxDimensionLength = 10;
    int minElementValue = 0;
    int maxElementValue = 100;

    int rows = new Random().Next(minDimensionLength, maxDimensionLength + 1);
    int columns = new Random().Next(minDimensionLength, maxDimensionLength + 1);
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minElementValue, maxElementValue + 1);
        }
    }
    return matrix;
}


