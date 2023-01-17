float[] array = new float[4];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(1, 100);
}
Console.WriteLine("Создан массив:");
Console.WriteLine("[{0}]", string.Join(", ", array));

float max = float.MinValue;
float min = float.MaxValue;

for (int i = 0; i < array.Length; i++) {
    if (array[i] < min) {
        min = array[i];
    } else if (array[i] > max) {
        max = array[i];
    }
}
Console.WriteLine("Разница между максимальным и минимальным значением в массиве");
Console.WriteLine(max - min);