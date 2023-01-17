String number = Console.ReadLine();
String[] array = new String[Convert.ToInt32(number.Length)];

for (int i = 0; i < array.Length; i++) {
    array[i] = number.Substring(i, 1);
}

int result = 0;
for (int i = 0; i < array.Length; i++) {
    result = result + Convert.ToInt32(array[i]);
}

Console.WriteLine(result);