using System;

namespace _5_function5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Shuffle(array);

            for(int i = 0; i < array.Length; i++)
            {     
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i + 1);
                int value = array[i];
                array[i] = array[j];
                array[j] = value;               
            }
        }                
    }
}