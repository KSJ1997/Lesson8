// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[n, m];


ArrayRandomNumber(num);
void ArrayRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

PrintArray(num);
void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");

        Console.WriteLine("");
    }
}

Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMeanOfEachColumn(num);
void ArithmeticMeanOfEachColumn(int[,] array)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < num.GetLength(0); i++)
        {
            average = (average + num[i, j]);
        }
        average = average / m;
        Console.Write(average + "; ");
    }

}
