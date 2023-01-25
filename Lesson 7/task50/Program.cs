int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

int[,]array = new int [m,n];

Console.WriteLine("Сформирован массив:");
Console.WriteLine();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {

        array[i,j] = rnd.Next(1, 99);
        Console.Write("{0}\t", float.Round((array[i, j]), 1));
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число для поиска:");
Console.WriteLine();

int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        if (array[i,j] == number) {
            Console.WriteLine("число найдено на позиции: " + i + ", " + j);
            return;
        } else if (i == m - 1 && j == n - 1 && array[i,j] != number) {
            Console.WriteLine("число не найдено");
        }
    }
}