//программа принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
string sequenceNCube = String.Empty;

while (count <= number) 
{
    sequenceNCube += count*count*count + " ";
    count++;
}

Console.WriteLine(number + "->" + sequenceNCube);
