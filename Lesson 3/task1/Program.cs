String number = Console.ReadLine();
String[] array = new String[Convert.ToInt32(number.Length)];

for (int i = 0; i < array.Length; i++) {
    array[i] = number.Substring(i, 1);
}

for(int i = 0; i < array.Length; i++) {
    if (i == 2) {
        Console.WriteLine("да");
        break;
    } else if (array[i] != array[array.Length - 1 - i]) {
        Console.WriteLine("нет");
        break;
    } 
}