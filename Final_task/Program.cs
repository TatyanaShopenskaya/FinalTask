﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов массива");
int size  = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

string[] CreateArray(int size)
{         
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Console.ReadLine(); 
    }
    return array; 
}

static void PrintArray(string[] array)
{
    Console.WriteLine("Заданный Вами массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

CreateArray(size);
PrintArray(array);



