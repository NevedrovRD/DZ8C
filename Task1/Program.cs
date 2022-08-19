// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);

    }

}    

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}

int [] temp = new int[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        temp[j] = matrix[i, j];
    Array.Sort(temp);
    Array.Reverse(temp);
    for (int k = 0; k < m; k++)
    {
        matrix[i, k] = temp[k];
        
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}  
