//Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
//треугольник Паскаля имеет свойства: на вершине и по бокам стоят единицы, а каждое число равно сумме расположенных над ним чисел

Console.WriteLine("Задайте количество строк треугольника Паскаля для вывода: ");
int rowNumbers = Int32.Parse(Console.ReadLine());
int[,] pascaleTriangle = FillPascalTriangle(rowNumbers);
PrintTriangle(pascaleTriangle);

int[,] FillPascalTriangle(int rows)
{
    int[,] matrix = new int[rows, rows];
    matrix[0, 0] = 1;

    for (int i = 1; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (j - 1 < 0)
                matrix[i, j] = 1;
            else
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }
    }
    return matrix;
}

void PrintTriangle(int[,] array)
{
    Console.Clear();
    int cellWidth = 5;
    int columns = array.GetLength(1);
    int columnAlign;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        columnAlign = (cellWidth * (columns - i)) / 2;
        for (int j = 0; j < columns; j++)
        {
            Console.SetCursorPosition(columnAlign, i);
            if (array[i, j] != 0)
                Console.Write(array[i, j]);
            columnAlign += cellWidth;
        }
        Console.WriteLine();
    }
}

