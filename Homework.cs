/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */

string[] strArr1 = new string[7] {"До","Ре","Ми", "Фа", "Соль", "Ля", "Си"};
string[] strArr2 = new string[strArr1.Length];

void NewArr(string[] strArr1, string[] strArr2)
{
    int i = 0;
    for (int j = 0; j < strArr1.Length; j++)
    {
        if (strArr1[j].Length <= 3)
        {
            strArr2[i] = strArr1[j];
            i++;
        } 
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}