int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{result(m, n)}");

int result(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return result(m - 1, 1);
    else
        return result(m - 1, result(m, n - 1));
}