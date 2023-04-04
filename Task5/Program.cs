Console.Clear();
Console.Write("Введите количество ступенек треугольника Паскаля: ");
string a = Console.ReadLine()!;
int n = Convert.ToInt32(a);
Console.WriteLine();
for (int y = 0; y < n; y++)
{
    int b = 1;
    for (int m = 0; m < n - y; m++)
    {
        Console.Write("   ");
    }

    for (int x = 0; x <= y; x++)
    {
        Console.Write("   {0:D} ", b);
        b = b * (y - x) / (x + 1);
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();