// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j],4}");
		}
		Console.WriteLine(" |");
	}
}

void ArrangeArrayFromBigToLowByRows(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1) - 1; j++)
		{
			for (int k = j + 1; k < arr.GetLength(1); k++)
			{
				if (arr[i, k] > arr[i, j])
				{
					int temp = arr[i, j];
					arr[i, j] = arr[i, k];
					arr[i, k] = temp;
				}
			}
		}
	}
}

int[,] array = CreateMatrixRndInt(5, 7, -10, 10);
PrintMatrix(array);
ArrangeArrayFromBigToLowByRows(array);
Console.WriteLine("");
PrintMatrix(array);
