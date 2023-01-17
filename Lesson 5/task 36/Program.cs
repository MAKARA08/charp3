int[] array = new int[4];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(1, 100);
}
Console.WriteLine("Создан массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

int result = 0; 
for (int i = 0; i < array.Length; i++) {
    if (i % 2 != 0) {
        result += array[i];
        }
}
Console.WriteLine("Сумма элементов на нечетных позициях (относительно индекса):");
Console.WriteLine(result);