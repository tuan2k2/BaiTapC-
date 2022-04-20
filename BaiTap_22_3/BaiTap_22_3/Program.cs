using System;
using System.Text;

namespace BaiTap_22_3
{
    class Program
    {
        public static void showMenu()
        {
            Console.WriteLine("1. Cho số tự nhiên n nhập từ bàn phím, hãy viết chương trình in ra tổng của n số tự nhiên đầu tiên sử dụng vòng lặp.");
            Console.WriteLine("2. Nhập vào số tiền gửi ban đầu, tiền lãi mỗi năm và số năm gửi tiền hãy tính số tiền nhận được sau n năm (biết lãi tính theo hình thức lãi kép).");
            Console.WriteLine("3. Nhập vào một số tự nhiên n, in ra màn hình tam giác cân rỗng có chiều cao là n được tạo thành từ những dấu *, có sử dụng vòng lặp.");
            Console.WriteLine("4. Bài 59:");
            Console.WriteLine("5. Bài 60:");
            Console.WriteLine("6. Bài 61:");
            Console.WriteLine("7. Bài 62:");
            Console.WriteLine("8.Thoát");
        }
        static int getInt(string mess)
        {
            Console.Write(mess);
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        static double getDouble(string mess)
        {
            Console.Write(mess);
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

        static void bai1()
        {
            int n = getInt(" nhập n =");
            int S = 0;
            for (int i=1; i<=n; i++)
            {
                S = S + i;
            }
            Console.WriteLine(" Tổng n số đầu tiên : {0}",S);
        }



        static void bai2()
        {
            double sotien = getDouble("Nhap so tien gui:");
            double lai = getDouble("Nhap lai suat hang nam:");
            int sonam = getInt("Nhap so nam gui tien: ");

            for (int i = 1; i <=  sonam; i++)
            {
                sotien += sotien * lai;
            }
            Console.WriteLine("So tien sau {0} nam la {1} ", sonam, sotien);
        }


        static void bai3()
        {
            int docao = getInt("Nhap chieu cao tam giac: ");
            for (int a = 1; a <= docao - 1; a++)
                Console.Write("  ");
            Console.Write("*\n");
            for (int b = 1; b <= docao - 2; b++)
            {
                for (int c = b; c <= docao - 2; c++)
                    Console.Write("  ");
                Console.Write("*");
                for (int d = 1; d <= b * 2 - 1; d++)
                    Console.Write("  ");
                Console.Write("*\n");
            }
            for (int c = 1; c <= docao * 2 - 1; c++)
                Console.Write("* ");
            Console.WriteLine("\n");
        }


        static void bai59()
        {
            int n;
            String[] can  = {"Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ"};
            String[] chi = {"Thân", "Dậu", "Tuất", "Hợi", "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi"};
            n = getInt("nhập năm");
            Console.WriteLine("{0} - {1} {2}\n", n, can[n % 10], chi[n % 12]);
            Console.WriteLine("{0} - {1} {2}\n", n + 60, can[n % 10], chi[n % 12]);
        }
        static bool check(int[] arr  , int size , int x)
        {
            for (int i =0; i<size; i++)
            {
                if (arr[i] ==x)
                {
                    return false;
                }    
            }  
                return true;
        }    
        static void nhapMang(out int[] arr)
        {
            int n = getInt("Nhập số phần tử của mảng: ");
            arr = new int[n];
            Random rand = new Random();
            int i = 0;
            while(i<n)
            {
                int x = rand.Next(100);
                if (check(arr, i, x))
                {
                    arr[i++] = x;
                }
            }    
        }

        static void HienMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        

        static void bai60()
        {

            int[] arr;
            nhapMang(out arr);
            HienMang(arr);
           
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose;
            while (true)
            {
                showMenu();
                choose = getInt("Chọn 1 Bài:  ");

                switch (choose)
                {
                    case 1:
                        bai1();
                        break;
                    case 2:
                        bai2();
                        break;
                    case 3:
                        bai3();
                        break;
                    case 4:
                        bai59();
                        break;
                    case 5:
                        bai60();
                        break;


                }
            }
        }
    }
}
