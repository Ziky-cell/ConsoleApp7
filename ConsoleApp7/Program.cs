using ConsoleApp7;
using System;


int[] myArray = new int[10];
int[] tempMyArray = new int[10];


for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = i;
}

Console.WriteLine("Исходный массив");
MyArrayUtills<int>.Print(myArray);

tempMyArray = MyArrayUtills<int>.Reverse(myArray);

Console.WriteLine("Обратный массив");
MyArrayUtills<int>.Print(tempMyArray);
