// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[n, m];
int [] array = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        array[i] += matrix[i, j];
    }

}    
int min = array[0];
int index = 0;
for (int i = 1; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
        index = i;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(min);
Console.WriteLine("Индекс строки " + index);