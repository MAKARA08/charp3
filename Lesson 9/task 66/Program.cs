int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (n > 0 && m > n) {
    for(int i = n; i <= m; i++) {
        result += i;
    }
}
Console.WriteLine(result);