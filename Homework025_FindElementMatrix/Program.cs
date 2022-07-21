//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.

int[,] numbers = FillMatrixRandomly();
PrintMatrix(numbers);

int indexOfElement = InputInt("Введите индекс элемента матрицы, одним числом (только двузначные числа): ");

int row = indexOfElement / 10;
int column = indexOfElement % 10;

if (!IsElementExist(row, column))
    Console.WriteLine("Элемента с таким индексом не существует");
else
    Console.WriteLine($"Зачение элемента матрицы с индексом [{row},{column}] равно {numbers[row, column]}");

bool IsElementExist(int row, int column)
{

if (row > numbers.GetLength(0) - 1 || column > numbers.GetLength(1))
    return false;
else
    return true;
}

int InputInt(string output)
{
    Console.WriteLine(output);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
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


