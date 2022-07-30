//НАписать 2 функции для работы с массивом: AddToArray и RemoveFromAray. Первая добавляет к числовому массиву значение, тем самым увеличивая массив, а вторая удаляет элемент под нужным индексом и уменьшает массив на 1. 

int size = 5;
int[] array = FillArrayRandomly(size, 0, 10);
Console.WriteLine("Original array");
PrintArray(array);

int newValue = InputInt("Enter new value to add: ");
AddToArray(ref array, newValue);
Console.WriteLine("Array with added element");
PrintArray(array);

int indexToDelete = InputInt("Enter index of element to delete: ");
RemoveFromArray(ref array, indexToDelete);
Console.WriteLine("Array after removing of element");
PrintArray(array);

void AddToArray(ref int[] array, int value)
{
    int[] extendedArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        extendedArray[i] = array[i];
    }
    extendedArray[extendedArray.Length - 1] = value;
    array = extendedArray;
}

void RemoveFromArray(ref int[] array, int index)
{
    if (index > array.Length - 1)
    {
        Console.WriteLine($"Error. Element with index {index} does not exist in array");
        return;
    }
    int[] cuttedArray = new int[array.Length - 1];
    for (int i = 0; i < cuttedArray.Length; i++)
    {
        if (i < index)
            cuttedArray[i] = array[i];
        else
            cuttedArray[i] = array[i + 1];
    }
    array = cuttedArray;
}

int[] FillArrayRandomly(int numberOfElements, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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



