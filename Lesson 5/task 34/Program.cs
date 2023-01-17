int[] array = new int[4];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(100, 999);
}
Console.WriteLine("Создан массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

int result = 0; 
for (int i = 0; i < array.Length; i++) {
    if (array[i] % 2 == 0) {
        result++;
        }
}
Console.WriteLine("Кол-во четных элементов в массиве:");
Console.WriteLine(result);