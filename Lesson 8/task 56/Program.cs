int m = Convert.ToInt32(Console.ReadLine());;
int n = Convert.ToInt32(Console.ReadLine());;

int min = 0;

int[,] array = new int[m, n];

newArray(array);
writeArray(array);

int minSum = sumLine(array, 0);

for (int i = 1; i < array.GetLength(0); i++) {
  int temp = sumLine(array, i);
  if (minSum > temp) {
    minSum = temp;
    min = i;
  }
}

Console.WriteLine(min+1);

int sumLine(int[,] array, int i) {
  int minSum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++) {
    minSum += array[i,j];
  }
  return minSum;
}

void newArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      array[i, j] = new Random().Next(1, 99);
    }
  }
}

void writeArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}