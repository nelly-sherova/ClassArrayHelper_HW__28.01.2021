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
        public static int Push(ref string[] arr, string el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length] = el;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length] = el;
            return arr.Length;
        }
        public static int Push(ref double[] arr, double el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length] = el;
            return arr.Length;
        }
        public static int Push(ref decimal[] arr, decimal el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length] = el;
            return arr.Length;
        }
        public static int Push(ref float[] arr, float el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length] = el;
            return arr.Length;
        }
        public static string Shift(ref string[] arr)
        {
            string el = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i+1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static int Shift(ref int[] arr)
        {
            int el = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i+1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static double Shift(ref double[] arr)
        {
            double el = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i+1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            decimal el = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i+1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static float Shift(ref float[] arr)
        {
            float el = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = arr[i+1];
            Array.Resize(ref arr, arr.Length - 1);
            return el;
        }
        public static int UnShift(ref string[] arr, string el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i >= 1; i--)
                arr[i] = arr[i - 1];
            arr[0] = el;
            return arr.Length;
        }
        public static int UnShift(ref int[] arr, int el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i >= 1; i--)
                arr[i] = arr[i - 1];
            arr[0] = el;
            return arr.Length;
        }
        public static int UnShift(ref double[] arr, double el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i >= 1; i--)
                arr[i] = arr[i - 1];
            arr[0] = el;
            return arr.Length;
        }
        public static int UnShift(ref decimal[] arr, decimal el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i >= 1; i--)
                arr[i] = arr[i - 1];
            arr[0] = el;
            return arr.Length;
        }
        public static int UnShift(ref float[] arr, float el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i >= 1; i--)
                arr[i] = arr[i - 1];
            arr[0] = el;
            return arr.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = {"1", "2"," 3", "4", "5", "6", "7"};
            Console.WriteLine(Array_Helper.UnShift(ref arr1, "kljh"));

            foreach (var item in arr1)
            {   
                Console.Write(" " + item);
            }
            Console.WriteLine(arr1.Length);
        }
    }
}
