using System;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 2, 2, 1, 2 }; // 2

            //Test case 14
            array = new int[] { 1, 2, 3, 2, 2, 4, 2, 2, 5, 2, 1 }; //2

            Console.WriteLine($"Array: {String.Join(',',array)}, Majority element : {MajorityElement(array)}");
        }

        public static int MajorityElement(int[] array)
        {
            int counter = 0;
            int current = 0;
            current = array[0];
            counter++;
            for (int i = 1; i < array.Length; i++)
            {
                if (counter == 0)
                {
                    current = array[i];
                    counter++;
                }
                else if (array[i] == current)
                    counter++;
                else
                {
                    counter--;
                }
            }
            return current;
        }

    }
}
