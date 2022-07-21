//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = FillMatrixRandomly();
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое в каждом столбце: ");
PrintArray(CountAverages(matrix));

double[] CountAverages(int[,] array)
{
    double[] arrayOfAverages = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        arrayOfAverages[i] = sum / array.GetLength(0);
    }
    return arrayOfAverages;
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
}

void PrintArray(double[] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[,] FillMatrixRandomly()
{
    int minDimensionLength = 1;
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


