//Заполните спирально массив 4 на 4.

int spiralSize = 4;
int[,] spiralArray = new int[spiralSize, spiralSize];

FillArraySpirally(spiralArray);
PrintMatrix(spiralArray);

void FillArraySpirally(int[,] array)
{
    int row = 0;
    int column = 0;
    //начинаем по часовой стрелке, значит сначала строку заполняем
    int rowDirection = 1;
    int columnDirection = 0;
    int changeDirection = 0;
    int touches = array.GetLength(0);

    for (int i = 0; i < array.Length; i++)
    {
        //стартовая позиция
        array[row, column] = i + 1;
        if (--touches == 0)
        {
            touches = array.GetLength(0) * (changeDirection % 2) + array.GetLength(1) * ((changeDirection + 1) % 2) - (changeDirection / 2 - 1) - 2;
            int temp = rowDirection;
            rowDirection = -columnDirection;
            columnDirection = temp;
            changeDirection++;
        }

        column += rowDirection;
        row += columnDirection;

    }
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


