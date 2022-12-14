// Написать программу, которая из имеющегося массива стрк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на ставре выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример:
// ["hello", "2", "world", ":-)"]


Console.WriteLine("Введите несколько элементов массива, состоищих из разного количества символов через пробел");
string elements = Console.ReadLine();
string[] words = elements.Split(' ');
string result = StringLessThree(words);
Console.WriteLine();
string[] resultWords = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
PrintArray(resultWords);
Console.WriteLine();


string StringLessThree(string[] arr)
{
    int size = arr.Length;
    string str = string.Empty;
        for(int i = 0; i < size; i++)
        {   
            if(arr[i].Length <= 3)
            str += arr[i];
            str = str + " ";
        }
        return str;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {  
        Console.Write($"[{array[i]}]");
            if (i < array.Length - 1) 
            {
               Console.Write(",");
            }
    }
}
