using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FirstDuplicateValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 5, 2, 3, 3, 4 };
            Console.WriteLine($"First Duplicate Value is : {FirstDuplicateValue(array)}");
        }

        public static int FirstDuplicateValue(int[] array)
        {
            int result = -1;
            //Dictionary<int, bool> dicNumbers = new Dictionary<int, bool>();
            //var dicNumbers = array.ToLookup(a => new { num = a, value = false }); 
            //Hashtable dicNumbers = new Hashtable();
            List<(int key, bool value)> dicNumbers = new List<(int key, bool value)>();
            for (int i = 0; i < array.Length; i++)
            {
                dicNumbers.Add((array[i], false));
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (dicNumbers.FirstOrDefault(a => a.key == array[i]).value)
                {
                    result = array[i];
                    break;
                }
                else
                {
                    dicNumbers[i] = (array[i], true);
                    //dicNumbers.FirstOrDefault(a => a.key == array[i]).value = true;
                }
            }
            return result;
        }

        //public static int FirstDuplicateValue(int[] array)
        //{
        //    int result = -1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i+1; j < array.Length ; j++)
        //        {
        //            if (array[i] == array[j])
        //            {
        //                if (result == -1)
        //                {
        //                    result = j;
        //                }
        //                else if(j < result)
        //                {
        //                    result = j;
        //                }
        //            }
        //        }
        //    }
        //    if (result != -1)
        //    {
        //        return array[result];
        //    }
        //    return result;
        //}
    }
}
