Console.Write("Введите число элементов массива: ");
int numberI = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную длину элемента массива: ");
int maxLength = int.Parse(Console.ReadLine());

PrintArray(EnterArray(numberI, maxLength));

string[] EnterArray(int len, int maxLen) 
{
	string[] result = new string[len];
	string tmp;
	for (int i = 0; i < len; i++)
	{
		Console.Write($"Введите {i + 1}-й элемент массива: ");
		tmp = Console.ReadLine(); // Вводим элементы массива через консоль
		if (tmp.Length <= maxLen) // Проверяем условие длины символов в элементе массива
			result[i] = tmp;
		else
			result[i] = null;
	}
	return result;
}

void PrintArray(string[] array)
{
	int first = 1;
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
	   if (array[i] != null) 
			if (first == 1) // Вывод первого элемента
			{
				Console.Write($"“{array[i]}”");
				first = 0;
			}
			else
				Console.Write($", “{array[i]}”"); // Вывод последующих элементов
	}
	Console.Write("]");
	Console.WriteLine(); // Для красоты в консоли
}