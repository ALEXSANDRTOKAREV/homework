using System;
class Program
{
static void PrintArray(int [] array)
{
	int count = array.Length;
	for(int i = 0; i < count; i++)
	{
		Console.WriteLine("[" + array[i] + "]");
	}
	Console.WriteLine();
}

static void Main(string[] args)
{
	int [] array = new int [0];
	Console.Write("Введите последовательность целых чисел массива без пробелов и запятых = ");
	var numbers = Console.ReadLine();
	int N = Convert.ToInt32(numbers);
			
	array = new int [array.Length+1];
	int [] a = array;
	for(int i = 0; i < a.Length; i++)
	{
		array[i] = a [i];
	}
	array [array.Length-1] = N;
	PrintArray(array);
}
}