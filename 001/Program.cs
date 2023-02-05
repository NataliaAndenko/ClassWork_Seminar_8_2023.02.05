/*
Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int[,] matrix = new int[5, 5];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10)
    ;
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
    }
}

void Change(int[,] arr)
{
    var temp = 0;
    int lastNum = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp = arr[0, i];
        arr[0, i] = arr[lastNum, i];
        arr[lastNum, i] = temp;
    }
}
//int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
Change(matrix);
PrintArray(matrix);