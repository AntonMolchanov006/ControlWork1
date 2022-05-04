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
        if(s.Length < 4)
        {
            arra[i] = string.Empty;
        }
    }
    return arra;
}

string [] ar = new string [0];
//FillArray(ar);
PrintArray(FillArray(ar));
PrintArray(SortArray(FillArray(ar)));

// string[] NewArray(string[] AS2)
// {
//     string[] Array; 
//     int count; 
//     string s;
//     Console.WriteLine("Enter strings:");
//     count = 0;
//     Array = new string[count];
//     do
//     {
//         s = Console.ReadLine();
//         if (s != "")
//         {
//             count++;
//             AS2 = new string[count];
//             for (int i = 0; i < AS2.Length - 1; i++)
//                 AS2[i] = Array[i];
//             AS2[count - 1] = s;
//             Array = AS2;
//         }
//     } while (s != "");
//     for (int i = 0; i < Array.Length; i++)
//         Console.Write(Array[i] + ", ");
//     return Array;
// }
// string[] AS2 = new string[2];
// NewArray(AS2);