﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
// массивами.

string[] array = {"dont wory", "Hulk", "TNT", "58", "Co2", ";)"};
string[] NewArray = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        NewArray[i] = array[i];
    }
}
NewArray = NewArray.Where( x => x != null).ToArray();
Console.Write(String.Join(" | ", NewArray));