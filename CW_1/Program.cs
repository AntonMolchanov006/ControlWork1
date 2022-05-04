Console.Clear();

string [] FillArray(string [] EmptyArray)
{
    string [] Array;
    int size = 0;
    string s = string.Empty;
    Console.WriteLine("Enter Strings: ");
    Array = new string [size];

    while(s != "end")
    {
        s = Convert.ToString(Console.ReadLine());
        size++;
        EmptyArray = new string [size];
        for (int i = 0; i < EmptyArray.Length - 1; i++)
        {
            EmptyArray[i] = Array[i];
        }
        EmptyArray[size - 1] = s;
        Array = EmptyArray;
    }
    return Array;
}

void PrintArray(string [] arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        Console.Write(arra[i] + " ");
    }
    Console.WriteLine();
}

string [] SortArray(string [] arra)
{
    string s;
    for (int i = 0; i < arra.Length; i++)
    {
        s = arra[i];
        if(s.Length > 3)
        {
            arra[i] = string.Empty;
        }
    }
    return arra;
}

string [] ar = new string [0];
PrintArray(SortArray(FillArray(ar)));