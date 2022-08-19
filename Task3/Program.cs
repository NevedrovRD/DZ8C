// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[n, m];
int [,] matrix1 = new int[n, m];
int [,] matrix2 = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
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

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix1[i, j] = new Random().Next(0, 10);
    }

}    
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix1[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix2[i, j] = matrix[i, j] * matrix1[i, j];
    }

}    

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix2[i, j] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}