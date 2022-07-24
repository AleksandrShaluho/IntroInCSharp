//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//на всякий случай посмотрел определение. Прямоугольный массив - не равно "квадратный массив". Прямоугольный - значит НЕ ступенчатый)

int[,] matrix = FillMatrixRandomly();
Console.WriteLine("Original matrix");
PrintMatrix(matrix);
Console.WriteLine("Sums of rows");
PrintArray(SumRowsElements(matrix));
Console.WriteLine("Index of row with minimal sum - " + MinValueInArray(SumRowsElements(matrix)));
Console.WriteLine("Index of row with minimal sum (with FindMinSumRowIndex) - " + FindMinSumRowIndex(matrix));

//способ через массив сумм строк. Длиннее зато потом методы можно переиспользовать, в теории.
int MinValueInArray(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[] SumRowsElements(int[,] array)
{
    int[] arrayOfSums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayOfSums[i] += array[i, j];
        }
    }
    return arrayOfSums;
}
//другой способ, проще и без доп. массива.
int FindMinSumRowIndex(int[,] array)
{
    int sum = 0;
    int min = int.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (min > sum)
        {
            min = sum;
            minIndex = i;
        }
	sum = 0;
	
    }
    return minIndex;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
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

