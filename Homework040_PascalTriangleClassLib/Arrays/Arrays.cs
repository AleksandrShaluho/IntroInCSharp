namespace Arrays;
public class PascalTriangle
{
    public int cellWidth = 3;
    int[,] triangle;
    public int size = 5;
    public void Fill()
    {
        triangle = new int[size, size];
        triangle[0, 0] = 1;

        for (int i = 1; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j - 1 < 0)
                    triangle[i, j] = 1;
                else
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }
    }

    public void Print()
    {
        Console.Clear();
        int columns = triangle.GetLength(1);
        int columnAlign;
        for (int i = 0; i < triangle.GetLength(0); i++)
        {
            columnAlign = (cellWidth * (columns - i)) / 2;
            for (int j = 0; j < columns; j++)
            {
                Console.SetCursorPosition(columnAlign, i);
                if (triangle[i, j] != 0)
                    Console.Write(triangle[i, j]);
                columnAlign += cellWidth;
            }
            Console.WriteLine();
        }
    }

}
