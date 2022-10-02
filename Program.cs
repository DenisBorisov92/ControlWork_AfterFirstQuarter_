string[] CreateArray(int text)
{
    
    string[] array = new string[text];
    for (int i = 0; i < text; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    
}

string[] ShowElements (string[] array)
{
    string [] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
             newArray[count] = array[i];
             count++;
        }
    }
    return newArray;
} 
