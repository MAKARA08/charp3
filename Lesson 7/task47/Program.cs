int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

float[,]array = new float [m,n];

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        // Получение случайного знака
        int sign = 0;
        while (true) {
            sign = rnd.Next(-10, 10);

            if (sign != 0) {
                break;
            }
        }

        // Заполнение массива
        array[i,j] = Convert.ToSingle((float)rnd.Next(1, 999) / (float)rnd.Next(1, 99) * sign);
        Console.Write("{0}\t", float.Round((array[i, j]), 1));
    }
    Console.WriteLine();
}
