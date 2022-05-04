Console.Clear();

string [] FillArray(string [] EmptyArray)
{
    string [] Array;
    int size = 0;
    string s = string.Empty;
    Console.WriteLine("Enter Strings and to finish enter end: ");
    Array = new string [size]; // инициализируем массив размерностью 0
// запускаем цикл для записи строк в массив до тех пор пока пользователь не введет слово end
    while(s != "end")
    {
        s = Convert.ToString(Console.ReadLine());    // вводим строку с консоли
        size++; // на каждом круге цикла увеличиваем размер массива для записи нового элемента
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

void PrintArray(string [] arra)   // создали метод для вывода массива на экран
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
        if(s.Length > 3) // если длина строки больше 3 знаков "обнуляем" строку
        {
            arra[i] = string.Empty;
        }
    }
    return arra;
}

string [] ar = new string [0];
PrintArray(SortArray(FillArray(ar)));