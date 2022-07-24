//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//проверяем сначала совместимость матриц, потом считаем произведение. Каждый элемент новой матрицы это сумма произведений
//элементов строки первой матрицы на соответствующие элементы столбца второй матрицы

int[,] firstMatrix = FillMatrixRandomly();
int[,] secondMatrix = FillMatrixRandomly();

Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);

if (!IsCompatibleMatrices(firstMatrix, secondMatrix))
    return;
else
{
    int[,] multipleMatrix = GetMultiplyOfMatrices(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение матриц");
    PrintMatrix(multipleMatrix);
}


bool IsCompatibleMatrices(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
        return true;
    else if (matrixB.GetLength(1) == matrixA.GetLength(0))
    {
        Console.WriteLine("Матрицы несовместимы. Возможно, вы хотели в первом сомножителе указать матрицу B (матрица B совместима с матрицей A)");
        return false;
    }
    else
    {
        Console.WriteLine("Матрицы несовместимы");
        return false;
    }
}

int[,] GetMultiplyOfMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplyMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrixA.GetLength(1); m++)
            {
                sum += matrixA[i, m] * matrixB[m, j];
            }
            multiplyMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return multiplyMatrix;
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
    int maxElementValue = 5;

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

