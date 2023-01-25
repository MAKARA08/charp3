int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

int[,]array = new int [m,n];

Console.WriteLine("Сформирован массив:");
Console.WriteLine();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {

        array[i,j] = rnd.Next(1, 10);
        Console.Write("{0}\t", float.Round((array[i, j]), 1));
    }
    Console.WriteLine();
}

double[] result = new double[n];
int x = 0;
for (int i = 0; i < n; i++) {
    double var = 0;
    for (int j = 0 ; j < m; j++) {
        var += array[j, i];
    }
    if (x < result.Length) {
        result[x] = (var / m);
        x++;
    }
}
Console.WriteLine("Средние числа по столбцам:");
Console.WriteLine("[{0}]", string.Join("; ", result));