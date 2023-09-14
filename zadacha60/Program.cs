// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int depth, int rows, int columns)
{
	int[,,] matrix = new int[depth, rows, columns];
	Random rnd = new Random();
	int num = 0;
	for (int i = 0; i < depth; i++)
	{
		for (int j = 0; j < rows; j++)
		{
			for (int k = 0; k < columns; k++)
			{
				matrix[i, j, k] = ++num;
			}
		}
	}
	return matrix;
}

void PrintMatrix(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write("|");
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k],4}");
			}
			Console.WriteLine(" |");
		}
		Console.WriteLine();
	}
}

void PrintElementsOfArray3dWithIndex(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k],2}[{i}, {j}, {k}] ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}

int rowsArray = 3;
int columnsArray = 3;
int depthArray = 4;
int[,,] array = CreateMatrixRndInt(depthArray, rowsArray, columnsArray);
PrintMatrix(array);
PrintElementsOfArray3dWithIndex(array);