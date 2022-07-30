//Написать функцию Shuffle, которая перемешивает элементы массива  в случайном порядке.

int size = InputInt("Enter size of array: ");
int[] array = FillArray(size);
Console.WriteLine("Original array");
PrintArray(array);

ShuffleArray(ref array);
Console.WriteLine("Shuffled array");
PrintArray(array);

void ShuffleArray(ref int[] array)
{
    int buffer = 0;
    int bufferIndex = 0;
    Random rnd = new Random();
    int steps = 3;
    for (int i = 1; i <= steps; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            buffer = array[j];
            bufferIndex = rnd.Next(0, array.Length);
            array[j] = array[bufferIndex];
            array[bufferIndex] = buffer;
        }
    }
}

int[] FillArray(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = i+1;
    }
    return array;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    //пустая строка чтобы визуально отделить вывод
    Console.WriteLine();
}

int InputInt(string output)
{
    Console.WriteLine(output);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


