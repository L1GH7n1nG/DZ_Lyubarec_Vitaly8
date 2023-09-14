// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateSpiralMatrixInt(int rows, int columns)
{
	int[,] matrix = new int[rows, columns];
	int num = 1; // Начальное значение для заполнения матрицы

	// Инициализация границ матрицы
	int top = 0; // Верхняя граница
	int bottom = rows - 1; // Нижняя граница
	int left = 0; // Левая граница
	int right = columns - 1; // Правая граница

	while (num <= rows * columns)
	{
		// Заполняем верхнюю горизонтальную строку
		for (int i = left; i <= right; i++)
		{
			matrix[top, i] = num++;
		}
		top++; // Смещаем верхнюю границу вниз

		// Заполняем правый вертикальный столбец
		for (int i = top; i <= bottom; i++)
		{
			matrix[i, right] = num++;
		}
		right--; // Смещаем правую границу влево

		// Заполняем нижнюю горизонтальную строку
		for (int i = right; i >= left; i--)
		{
			matrix[bottom, i] = num++;
		}
		bottom--; // Смещаем нижнюю границу вверх

		// Заполняем левый вертикальный столбец
		for (int i = bottom; i >= top; i--)
		{
			matrix[i, left] = num++;
		}
		left++; // Смещаем левую границу вправо
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

int[,] array = CreateSpiralMatrixInt(4, 4);
PrintMatrix(array);


