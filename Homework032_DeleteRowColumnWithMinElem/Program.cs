//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[,] matrix = FillMatrixRandomly();
Console.WriteLine("Original matrix");
PrintMatrix(matrix);

int[] index = GetIndexOfMinValue(matrix);
Console.WriteLine("Cutted Matrix");
PrintMatrix(GetCuttedMatrix(matrix, index));

int[] GetIndexOfMinValue(int[,] array)
{
    int min = int.MaxValue;
    int[] minIndex = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[,] GetCuttedMatrix(int[,] array, int[] crosspoint)
{
    int[,] cuttedMatrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < cuttedMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < cuttedMatrix.GetLength(1); j++)
        {
            if (i < crosspoint[0] && j < crosspoint[1])
                cuttedMatrix[i, j] = array[i, j];
            else if (i < crosspoint[0] && j >= crosspoint[1])
                cuttedMatrix[i, j] = array[i, j + 1];
            else if (i >= crosspoint[0] && j < crosspoint[1])
                cuttedMatrix[i, j] = array[i + 1, j];
            else if (i >= crosspoint[0] && j >= crosspoint[1])
                cuttedMatrix[i, j] = array[i + 1, j + 1];
        }
    }
    return cuttedMatrix;
}

void PrintMatrix(int[,] array)
{
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
    int minDimensionLength = 2;
    int maxDimensionLength = 8;
    int minElementValue = 0;
    int maxElementValue = 10;

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

