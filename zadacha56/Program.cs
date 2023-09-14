// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
			Console.Write($"{arr[i, j],6}");
		}
		Console.WriteLine(" |");
	}
}

int[] SumOfMatrixRows(int[,] matrix)
{
	int[] sums = new int[matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			sum += matrix[i, j];
		}
		sums[i] = sum;
	}
	Console.Write("Построчная сумма элементов: ");
	return sums;
}

void FindSumMinRow(int[] array)
{
	int minValue = array[0];
	int minIndex = 0;
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] < minValue)
		{
			minValue = array[i];
			minIndex = i;
		}
	}
	Console.WriteLine($"Номер строки с наименьшей суммой элементов = {minIndex + 1}");
	Console.WriteLine($"Значение наименьшего элемента: {minValue}");
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < (array.Length - 1)) Console.Write($"{array[i]}, ");
		else Console.Write($"{array[i]}");
	}
	Console.Write("]");
}

int[,] array = CreateMatrixRndInt(5, 5, 10, 100);
PrintMatrix(array);
int[] rowsSums = SumOfMatrixRows(array);
PrintArray(rowsSums);
Console.WriteLine("");
FindSumMinRow(rowsSums);