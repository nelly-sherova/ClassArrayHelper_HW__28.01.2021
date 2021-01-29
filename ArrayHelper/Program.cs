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
            arr[arr.Length-1] = el;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = el;
            return arr.Length;
        }
        public static int Push(ref double[] arr, double el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = el;
            return arr.Length;
        }
        public static int Push(ref decimal[] arr, decimal el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = el;
            return arr.Length;
        }
        public static int Push(ref float[] arr, float el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length-1] = el;
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
        public static void ShowArray(string[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public static void ShowArray(double[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public static void ShowArray(decimal[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public static void ShowArray(float[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] arr = {"Зебра", "Жираф", "Слон", "Носорог", "Тигр", "Леопард"};
            //int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //double[] arr = {1.3, 6.7, 4.9};
            //decimal[] arr = {1.3m, 6.7m, 4.9m};
            //float[] arr = {1.3f, 6.7f, 4.9f};
            Console.WriteLine("Ваш массив:");
            Array_Helper.ShowArray(arr);
            Console.WriteLine("Ваш массив после применения метода Pop:");
            Console.Write("Удалили: "); Console.WriteLine(Array_Helper.Pop(ref arr));
            Console.Write("Осталось: "); Array_Helper.ShowArray(arr);
            Console.WriteLine("Ваш массив после применения метода Push:");
            Console.Write("Длина массива: "); 
            Console.WriteLine(Array_Helper.Push(ref arr, "Крокодил"));
            //Console.WriteLine(Array_Helper.Push(ref arr, 100));
            //Console.WriteLine(Array_Helper.Push(ref arr, 1));
            //Console.WriteLine(Array_Helper.Push(ref arr, 1m));
            //Console.WriteLine(Array_Helper.Push(ref arr, 1f));
            Console.Write("Весь массив: "); Array_Helper.ShowArray(arr);
            Console.WriteLine("/nВаш массив после приминения метода Shift: ");
            Console.Write("Удалили: "); Console.WriteLine(Array_Helper.Shift(ref arr));
            Console.Write("Осталось: "); Array_Helper.ShowArray(arr);
            Console.WriteLine("/nВаш массив после приминения метода UnShift: ");
            Console.Write("Длина массива: "); 
            Console.WriteLine(Array_Helper.UnShift(ref arr, "Пингвин"));
            //Console.WriteLine(Array_Helper.UnShift(ref arr, 0));
            //Console.WriteLine(Array_Helper.UnShift(ref arr, 1));
            //Console.WriteLine(Array_Helper.UnShift(ref arr, 1m));
            //Console.WriteLine(Array_Helper.UnShift(ref arr, 1f));
            Console.Write("Весь массив: "); Array_Helper.ShowArray(arr);
        }
    }
}
