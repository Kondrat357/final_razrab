// Задача


void Main()
{
       
        string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
        string[] result1 = FilterStringsByLength(array1, 3);
        Console.WriteLine("Пример 1:");
        PrintArray(array1, "Исходный массив");
        PrintArray(result1, "Результат");
        
        string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
        string[] result2 = FilterStringsByLength(array2, 3);
        Console.WriteLine("\nПример 2:");
        PrintArray(array2, "Исходный массив");
        PrintArray(result2, "Результат");
        
        string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };
        string[] result3 = FilterStringsByLength(array3, 3);
        Console.WriteLine("\nПример 3:");
        PrintArray(array3, "Исходный массив");
        PrintArray(result3, "Результат");
        
    }
    
    static string[] FilterStringsByLength(string[] inputArray, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                count++;
            }
        }
        
        string[] result = new string[count];
        int index = 0;
        
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                result[index] = inputArray[i];
                index++;
            }
        }
        
        return result;
    }
    
   
    void PrintArray(string[] array, string message)
    {
        Console.Write($"{message}: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
}    

Main();
