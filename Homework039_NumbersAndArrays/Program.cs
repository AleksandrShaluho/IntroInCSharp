//Написать программу со следующими командами:
//- SetNumbers - пользователь вводит числа через пробел, а программа запоминает их в массив. 
//AddNumbers - пользователь вводит числа, которые добавятся к уже существующему массиву
//RemoveNumbers - пользователь вводит числа, которые если найдутся в массиве, то будут удалены.
//Numbers - вывод текущего массива
//Sum - найдется сумма всех элементов чисел.

string userCommand = String.Empty;
int[] numbersArray = new int[0];

Console.WriteLine("Программа для работы с массивами. Введите номер команды из списка ниже.");
Console.WriteLine("1 - setnumbers. Создать массив с числами. \n2 - addnumbers. Добавить числа в созданный массив.");
Console.WriteLine("3 - removenumbers. Удалить числа из массива. \n4 - numbers. Вывести массив на экран.");
Console.WriteLine("5 - sum. Вывести сумму всех чисел в массиве. \n6 - exit. Выход из программы.");

while (true)
{
    userCommand = Console.ReadLine();
    switch (userCommand)
    {
        case "6":
            return;
        case "1":
            numbersArray = SetNumbers();
            break;
        case "2":
            AddNumbers(ref numbersArray);
            break;
        case "3":
            RemoveNumbers(ref numbersArray);
            break;
        case "4":
            Numbers(numbersArray);
            break;
        case "5":
            Sum(numbersArray);
            break;
        default:
            Console.WriteLine($"Неизвестная или неправильная команда {userCommand}.");
            break;
    }
    Console.WriteLine("Введите команду: ");
}

int[] SetNumbers()
{
    Console.WriteLine("Введите числа через пробел: ");
    string[] stringNumbers = Console.ReadLine().Split(" ");
    int[] array = new int[stringNumbers.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(stringNumbers[i]);
    }
    return array;
}


void AddNumbers(ref int[] array)
{
    Console.WriteLine("Введите числа, которые нужно добавить в массив,  через пробел: ");
    int[] newNumbers = Console.ReadLine().Split(" ").Select(Int32.Parse).ToArray();
    int[] extendedArray = new int[array.Length + newNumbers.Length];
    for (int i = 0; i < array.Length; i++)
    {
        extendedArray[i] = array[i];
    }
    for (int i = array.Length; i < extendedArray.Length; i++)
    {
        extendedArray[i] = newNumbers[i - array.Length];
    }
    array = extendedArray;
}

void RemoveNumbers(ref int[] array)
{
    if (array.Length == 0)
        Console.WriteLine("Массив чисел еще не был создан. Задайте массив командой setnumbers.");
    else
    {
        Console.WriteLine("Введите числа, которые нужно удалить из массива (если ои там есть),  через пробел: ");
        int[] numbersToDelete = Console.ReadLine().Split(" ").Select(Int32.Parse).ToArray();
        int[] bufferArray = new int[array.Length];
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < numbersToDelete.Length; j++)
            {
                if (array[i] == numbersToDelete[j])
                    break;
                else if (j == numbersToDelete.Length - 1)
                {
                    bufferArray[count] = array[i];
                    count++;
                }
            }
        }
        int[] cuttedArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            cuttedArray[i] = bufferArray[i];
        }
        array = cuttedArray;
    }
}

void Numbers(int[] array)
{
    if (array.Length == 0)
        Console.WriteLine("Массив чисел еще не был создан. Задайте массив командой setnumbers.");
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

void Sum(int[] array)
{
    if (array.Length == 0)
        Console.WriteLine("Массив чисел еще не был создан. Задайте массив командой setnumbers.");
    else
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма всех элементов массива составляет " + sum);
    }
}

