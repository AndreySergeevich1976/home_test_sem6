bool Answer (string str){
    for (int i=0;i<str.Length/2;i++){
        if (str[i]!=str[str.Length-1-i]){
            return false;
        }

    }
    return true;
}
void PrintAnswer(bool answer){
    if (answer==true){
    Console.WriteLine("Yes");
    }
    else {
    Console.WriteLine("No");
    }
}
Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
PrintAnswer(Answer(str));