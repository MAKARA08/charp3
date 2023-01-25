int counter = 0;
while(true) {
    String readline = Console.ReadLine();
    if (int.TryParse(readline, out int numericValue)){
        if (Convert.ToInt32(readline) > 0) {
            counter++;
        }
    } else {
        break;
    }
}
Console.WriteLine(counter);