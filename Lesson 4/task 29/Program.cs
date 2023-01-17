int[] array = new int[8];


for (int i = 0; i < array.Length; i++) {
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[{0}]", string.Join(", ", array));