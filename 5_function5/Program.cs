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
            for (int numbers = 0; numbers < array.Length; numbers++)
            {
                Random random = new Random();
                int tempArray = random.Next(numbers + 1);
                int value = array[numbers];
                array[numbers] = array[tempArray];
                array[tempArray] = value;
            }
        }
    }
}
