int size = InputInt("Введите размер массива: ");
int [] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]=-numbers[i];
}

PrintArray(numbers);

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
