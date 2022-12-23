// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)


double[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    double[,] array = new double[rows, columns];
    int i = 0, j = 0, k = 0;
    while (i < rows)
    {
        j = 0;
        while (j < columns)
        {
            k = new Random().Next(0, 2);  // Этот коэффициент определяет будет ли получаемый элемент массива целочисленным или нет

            array[i, j] = new Random().Next(-10, 11) + k * Math.Round(rnd.NextDouble(), 1);
            j++;
        }
        i++;
    }
    return array;
}

void PrintArray(double[,] array)
{
    int i = 0, j = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            Console.Write("{0}\t", array[i, j]);
            j++;
        }
        Console.WriteLine(" ");
        i++;
    }
}

Console.Write("Enter the number of rows... ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns... ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("The computer selects the elements of the array... ");
double[,] array = new double[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);

void CheckByPosition(double[,] array)
{
    Console.Write("Enter the number of the row of element... ");
    int rowNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of the column of element... ");
    int columnNumber = int.Parse(Console.ReadLine()!);
    if(rowNumber >= array.GetLength(0) || rowNumber < 0 || columnNumber >= array.GetLength(1) || columnNumber < 0)
    {
        Console.WriteLine("There is no element with such coordinates in the array");
    }
    else
    {
        Console.WriteLine($"On the {rowNumber} row of the {columnNumber} column there is an element {array[rowNumber,columnNumber]}");
    }
}

CheckByPosition(array);
