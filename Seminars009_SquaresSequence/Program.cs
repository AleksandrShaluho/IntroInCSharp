//программа принимает на вход число N и выводит последовательность квадратов чисел от 1 до N

Console.WriteLine("Введите число N: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
int currentNumber = 1;
string sequence = "";
 
while (currentNumber <= endNumber)
{
    sequence = sequence + currentNumber*currentNumber + " ";
    currentNumber++;
}
Console.WriteLine($"Число - {endNumber}. Последовательность квадратов: {sequence}");

