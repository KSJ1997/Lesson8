// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[4, 4];

PositionElementArray(num);
void PositionElementArray(int[,] num)
{
    if (n > num.GetLength(0) || m > num.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента, расположенного в строке {m} в столбце {n}: ");

        ArrayRandomNumber(num);
        void ArrayRandomNumber(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(-100, 100) / 10;
                }
            }
        }

        PrintArray(num);
        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine("");
            }
        }
    }
}
