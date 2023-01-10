//Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Примеры:
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// ["Russia", "Denmark", "Kazan"] → []

void ThreeDigitSymbol(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] arr1;
Console.WriteLine("Введите слова,символы либо цифры через пробел:");
string line = Console.ReadLine();
arr1 = line.Split(' ');
string[] arr2 = new string[arr1.Length];
ThreeDigitSymbol(arr1, arr2);
PrintArray(arr2);