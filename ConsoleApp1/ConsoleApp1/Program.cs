using System;

namespace ConsoleApp1
{
    class Program
    {
        static void NhapMang(int [] arr , int n)
        {
            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static void InMang(int[] arr)
        {
            Console.WriteLine("In mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Phan tu [{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine();
        }

        static int max(int [] arr,int n)
        {
           int mx = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                }
            }
            return mx;
        }
        static void Main(string[] args)
        {
            int bien = 100;
            int[] arr = new int[bien];
            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            NhapMang(arr,bien);
            InMang(arr);
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max(arr,bien));
            Console.ReadKey();
        }
    }
}
