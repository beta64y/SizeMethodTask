using System;

namespace Ozymandias
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ReSize(ref array, 4);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        static void ReSize(ref int[] array, int size)
        {
            int[] newArray = new int[size];
            if (size > array.Length)
            {
                for (int i = 0;i<array.Length ; i++)
                {
                    newArray[i] = array[i];
                }
                for (int i = array.Length; i < size; i++)
                {
                    newArray[i] = 0;
                }
                array = newArray;
            }
            else if (size < array.Length)
            {
                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;

            }


        }

    }
}


