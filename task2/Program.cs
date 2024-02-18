int[] convert(string str)
{
    int n = str.Length;
    char chars = ' ';
    int[] utf8 = new int[n];
    for (int i = 0; i < str.Length; i++)
    {
        chars = Convert.ToChar(str[i]);
        utf8[i] = Convert.ToInt32(chars);
    }
    return utf8;
}
string change(int[] array)
{
    char chars = ' ';
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 65 && array[i] <= 90)
        {
            array[i] += 32;
        }
        chars = Convert.ToChar(array[i]);
        result += Convert.ToString(chars);
    }
        return result;
}
Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
int[] utf8=convert(str);
Console.WriteLine(change(utf8));
