//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] cube = FillArray3d();
PrintArray3d(cube);



void PrintArray3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] FillArray3d()
{
    int minDimensionLength = 2;
    //по условию двузначные числа не должны повторяться. значит у нас есть не более 90 чисел.
    int maxDimensionLength = 4;
    int minElementValue = 10;
    int maxElementValue = 99;

    int width = new Random().Next(minDimensionLength, maxDimensionLength + 1);
    int heigth = new Random().Next(minDimensionLength, maxDimensionLength + 1);
    int depth = new Random().Next(minDimensionLength, maxDimensionLength + 1);

    int[,,] array3D = new int[width, heigth, depth];
    int buffer = 0;
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < heigth; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                //перед записью числа в массив проверим, было ли такое число
                buffer = new Random().Next(minElementValue, maxElementValue + 1);

                if (IsNumberExist(array3D, buffer))
                    k--;
                else
                    array3D[i, j, k] = buffer;
            }
        }
    }
    return array3D;
}

bool IsNumberExist(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                    return false;
            }
        }
    }
    return false;
}





