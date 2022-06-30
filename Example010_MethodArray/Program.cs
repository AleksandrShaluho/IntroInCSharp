int[] array = {9,8,6,4,2,11,14,16};
int ValueToFind = 4;
int ArrayLength = array.Length;
int Index = 0;

while (Index < ArrayLength)
{
    if (array[Index] == ValueToFind) 
    {
        Console.WriteLine(Index);
        break;
    }
    Index++;
}


