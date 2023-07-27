// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] ReadToArray(string text)
{
    Console.WriteLine(text);
    string[] array = Console.ReadLine()!.Split().ToArray();
    return array;
}


string[] ConvertForTask(string[] array, int maxLength = 3)
{
    string[] newArray = new string[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= maxLength )
    {
        Array.Resize(ref newArray, newArray.Length + 1);
        newArray[newArray.Length - 1] = array[i];
    }

}
return newArray;
}


void Main()
{
    string[] userArray = ReadToArray("Ведите массив слов через пробел: ");
    Console.WriteLine(string.Join(", ", userArray));

    System.Console.WriteLine(string.Join(", ", ConvertForTask(userArray)));
}
Main();


