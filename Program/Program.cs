string[] LessThanThreeSymbols(string[] array){
    int resultLen = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length !> 3) resultLen++;
    }
    string[] result = new string[resultLen];
    int c = 0;
    foreach (string item in array)
    {
        if(item.Length !> 3){
            result[c] = item;
            c++;
        }
    }
    return result;
}

void PrintArray(string[] array){
    foreach (string item in array)
    {
        System.Console.Write($"{item} ");
    }
}

string[] array = {"sas", "ds ", "21as", " ww a"};
PrintArray(LessThanThreeSymbols(array));