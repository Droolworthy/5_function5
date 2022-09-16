using System;

namespace _5_function5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            MakeShuffle(array);

            for(int i = 0; i < array.Length; i++)
            {     
                Console.Write(array[i] + " ");
            }           
        }

        static void MakeShuffle(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                SwapShuffle(i, array);
            }
        }
        
        static void SwapShuffle(int i, int[] array)
        {
            Random random = new Random();
            int j = random.Next(i + 1);
            int value = array[i];
            array[i] = array[j];
            array[j] = value;
        }
    }
}
