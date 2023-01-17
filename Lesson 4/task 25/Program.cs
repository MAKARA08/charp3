int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++) {
    result = result * a;
}
Console.WriteLine(result);