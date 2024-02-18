Console.WriteLine("Введите строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбов: ");
int m = int.Parse(Console.ReadLine()!);
char[, ] chars = new char[n, m];
for (int i = 0; i < chars.GetLength(0); i++){
    for (int j = 0; j < chars.GetLength(1); j++){
    Console.Write("Введите элемент массива: ");
    chars[i, j] = char.Parse(Console.ReadLine()!);
}
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
Console.WriteLine(string.Join("", chars));
string result = "";
foreach (char element in chars){
    result += element;
}
Console.WriteLine(result);

// Console.Clear();
// Console.Write("Кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++){
//     Console.Write("Введите элемент массива: ");
//     chars[i] = char.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");
// Console.WriteLine(string.Join("", chars));
// string result = "";
// foreach (char element in chars){
//     result += element;
// }
// Console.WriteLine(result);