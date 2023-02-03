int m = Convert.ToInt32(Console.ReadLine());;
int n = Convert.ToInt32(Console.ReadLine());;

int[,] array = new int[m, n];
newArray(array);
writeArray(array);
sortArray(array);
writeArray(array);

void writeArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void newArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      array[i, j] = new Random().Next(1, 99);
    }
  }
}

void sortArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      for (int k = 0; k < array.GetLength(1) - 1; k++) {
        if (array[i, k] < array[i, k + 1])
        {
          int var = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = var;
        }
      }
    }
  }
}