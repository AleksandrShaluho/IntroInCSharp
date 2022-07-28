//Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
//треугольник Паскаля имеет свойства: на вершине и по бокам стоят единицы, а каждое число равно сумме расположенных над ним чисел

using Arrays;


namespace ArraysProject
{
    class Program
    {
        static public void Main(string[] args)
        {
            PascalTriangle triangle = new();
            Console.WriteLine("Задайте количество строк треугольника Паскаля для вывода: ");
            triangle.size =Int32.Parse(Console.ReadLine());
	    triangle.Fill();
	    if (triangle.size < 15 && triangle.size >= 10)
		    triangle.cellWidth = 5;
	    else if (triangle.size >= 15)
		    triangle.cellWidth = 8;
		    
	    triangle.Print();
        }
    }
}
