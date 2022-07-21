//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Ограничений по числам в задаче нет,
//поэтому руководствуемся принципом из лекции "не делай, что не просили")

int rowsNumber = InputInt("Введите количество строк: ");
int columnsNumber = InputInt("Введите количество столбцов: ");
double[,] matrix = new double[rowsNumber, columnsNumber];

FillMatrix(matrix);
PrintMatrix(matrix);

void FillMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next() + new Random().NextDouble();
    }
}

void PrintMatrix(double[,] array)
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

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}


