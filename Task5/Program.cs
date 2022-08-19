// Заполните спирально массив 4 на 4.

int n = 4;
int m = 4;

int[,] matrix = new int[n, m];

int count = 1;
int i = 0;
int j = 0;

while (count <= n * m)
{
    matrix[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < m - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > m - 1)
        j--;
    else
        i--;
}

for (int x = 0; x < n; x++)
{
    for (int y = 0; y < m; y++)
        Console.Write(matrix[x, y] + "    ");
    Console.WriteLine();
    Console.WriteLine();
}
