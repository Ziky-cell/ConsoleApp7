using System;

namespace ConsoleApp7
{
    internal class MyArrayUtills<T>
    {
        public static void Print(T[] someArray)
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write($"{someArray[i]}|");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Создает массив в обратном порядке
        /// </summary>
        /// <param name="someArray">Массив на вход</param>
        /// <returns>Обратный массив</returns>

        public static T[] Reverse(T[] someArray)
        {
            int j = 0;

            T[] _tempArray = new T[someArray.Length];

            for (int i = someArray.Length - 1; i > 0; i--)
            {
                _tempArray[j] = someArray[i];
                j++;
            }

            return _tempArray;
        }
    }
}
