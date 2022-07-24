//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[,] matrix = FillMatrixRandomly();
Console.WriteLine("Original matrix");
PrintMatrix(matrix);

Console.WriteLine("Cutted Matrix");
PrintMatrix(GetCuttedMatrix(matrix));


int[,] GetCuttedMatrix(int[,] array)
{
    int min = int.MaxValue;
    int rowMinIndex = 0;
    int columnMinIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                rowMinIndex = i;
                columnMinIndex = j;
            }
        }
    }

    int[,] cuttedMatrix = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < cuttedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cuttedMatrix.GetLength(1); j++)
        {
	    if (i<rowMinIndex && j < columnMinIndex)
		cuttedMatrix[i, j] = array[i, j];
	    else
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
    int maxDimensionLength = 5;
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

