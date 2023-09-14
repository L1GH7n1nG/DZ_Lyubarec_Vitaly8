// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
			Console.Write($"{arr[i, j],7}");
		}
		Console.WriteLine(" |");
	}
}

int[,] MultiplicationOfTwoMatrix(int[,] matrix1, int[,] matrix2)
{
	if (matrix1.GetLength(1) != matrix2.GetLength(0) || matrix1.GetLength(0) == 0 || matrix2.GetLength(0) == 0 || matrix1.GetLength(1) == 0 || matrix2.GetLength(1) == 0)
	{
		Console.WriteLine("!!! Данные матрицы нельзя умножить друг на друга. Измените количество строк или столбцов для получения решения.");
		Console.WriteLine("!!! Количество столбцов первого массива должно быть = количеству строк второго.");
		return null;
	}

	//Добавил это сюда, чтобы в случае, если в значениях массива присутствует ноль, то не выводились print или writeline. Понимаю, что можно сделать через bool, но не стал запариваться) Надеюсь таким образом допустимо это сделать.

	Console.WriteLine("Первый двумерный массив.");
	PrintMatrix(matrix1);
	Console.WriteLine("");
	Console.WriteLine("Второй двумерный массив.");
	PrintMatrix(matrix2);

	int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	for (int i = 0; i < matrix1.GetLength(0); i++)
	{
		for (int j = 0; j < matrix2.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < matrix1.GetLength(1); k++)
			{
				sum += matrix1[i, k] * matrix2[k, j];
			}
			newMatrix[i, j] = sum;
		}
	}
	Console.WriteLine("");
	return newMatrix;
}

Console.WriteLine("----------Введите размеры массива----------");
Console.Write("Введите количество строк первого массива: ");
int rowsMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива: ");
int columnsMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("-Введите минимальное и максимальное значение элементов первого массива-");
Console.Write("Введите минимальное значение первого: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение первого: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(rowsMatrix1, columnsMatrix1, min1, max1);

Console.WriteLine("----------Введите размеры массива----------");
Console.Write("Введите количество строк второго массива: ");
int rowsMatrix2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива: ");
int columnsMatrix2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("-Введите минимальное и максимальное значение элементов второго массива-");
Console.Write("Введите минимальное значение второго: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение второго: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] array2 = CreateMatrixRndInt(rowsMatrix2, columnsMatrix2, min2, max2);

int[,] resultMultiplication = MultiplicationOfTwoMatrix(array, array2);
if (resultMultiplication != null)
{
	Console.WriteLine("Полученный двумерный массив после перемножения двух матриц.");
	PrintMatrix(resultMultiplication);
}



