int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1)) {
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (int k = 0; k < array.GetLength(0); k++) {
    for (int p = 0; p < array.GetLength(1); p++) {
      if (array[k,p] / 10 <= 0)
      Console.Write($" {array[k,p]} ");

      else Console.Write($"{array[k,p]} ");
    }
    Console.WriteLine();
}