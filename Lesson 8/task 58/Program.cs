int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());

int[,] first = new int[m, n];
int[,] second = new int[n, s];
int[,] result = new int[m,s];

newArray(first);
Console.WriteLine();
Console.WriteLine("first:");
writeArray(first);


newArray(second);
Console.WriteLine();
Console.WriteLine("second:");
writeArray(second);

main(first, second, result);

Console.WriteLine();
Console.WriteLine("first * second:");
writeArray(result);

void main(int[,] first, int[,] second, int[,] result) {
  for (int i = 0; i < result.GetLength(0); i++) {
    for (int j = 0; j < result.GetLength(1); j++) {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * second[k,j];
      }
      result[i,j] = sum;
    }
  }
}

void newArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      array[i, j] = new Random().Next(1,99);
    }
  }
}

void writeArray (int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}