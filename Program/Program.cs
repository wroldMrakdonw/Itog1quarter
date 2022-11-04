string[] LessThanThreeSymbols(string[] array){
    resultLen = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length !> 3) resultLen++;
    }
    result = new string[resultLen];
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length !> 3){
            array[c] = array[i];
            c++;
        }
    }
}