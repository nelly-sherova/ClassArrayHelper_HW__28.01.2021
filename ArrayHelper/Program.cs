using System;

namespace ArrayHelper
{
    public static class Array_Helper
    {
        public static string Pop(ref string[] arr)
        {
            string el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static int Pop(ref int[] arr)
        {
            int el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static double Pop(ref double[] arr)
        {
            double el = arr[arr.Length - 1];;
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            decimal el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static float Pop(ref float[] arr)
        {
            float el = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = {1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(Array_Helper.Pop(ref arr1));
            foreach (var item in arr1)
            {   
                Console.Write(item);
            }
            Console.WriteLine(arr1.Length);
        }
    }
}
