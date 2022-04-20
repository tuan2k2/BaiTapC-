using System;
using System.Text;

namespace baiTap_Mang
{
    class Program
    {

        public static void showMenu()
        {
            Console.WriteLine("1. Bài 59");
            Console.WriteLine("2. Bài 61");
            Console.WriteLine("3. Bài 63");
            Console.WriteLine("4. Bài 65");
            Console.WriteLine("5. Bài 67");
            Console.WriteLine("6. Thoát");
        }

        static int getInt(string mess)
        {
            Console.Write(mess);
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        static void bai59()
        {
            int n;
            String[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            String[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            n = getInt("nhập năm");
            Console.WriteLine("{0} - {1} {2}\n", n, can[n % 10], chi[n % 12]);
            Console.WriteLine("{0} - {1} {2}\n", n + 60, can[n % 10], chi[n % 12]);
        }


       
        static int[] nhap_Mang(ref int[] a, ref int so)
        {
            so = getInt("Ban muon nhap bao nhieu so:");
            a = new int[so];
            for (int i = 0; i < so ; i++)
            {
                Console.Write("Nhap so thu {0}:", (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        

        static void xuat_Mang(int[] a, ref int so)
        {
            for (int i = 0; i < so; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }

        static void bai61()
        {
            int s = 0;
            int n = 0;
            int[] arr = new int [100];
            nhap_Mang(ref arr, ref n);
            xuat_Mang(arr, ref n);
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] >= 0)
                   s = s + arr[i];
            }

            Console.WriteLine("\nTong cac so nguyen duong trong mang: " + s);
            int c = 0;
            int p = getInt("Nhap vi tri phan tu muon xoa: ");
            while (c != p - 1)
                c++;
            while (c < n - 1)
            {
                arr[c] = arr[c + 1];
                c++;
            }
            n--;
            xuat_Mang(arr, ref n);
        }

        static void Bai63()
        {
            int n =0;
            int[] arr = new int[100];
            nhap_Mang(ref arr, ref n);
            xuat_Mang(arr, ref n);
            int count = 0;
            for(int i =0; i<arr.Length; i++)
            {
                if (arr[i] % 4 == 0 && arr[i] % 10 == 6)
                    count++;
            }
            Console.WriteLine("\nCo {0} phan tu chia het cho 4 va co tan cung bang 6!", count);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    arr[i] = arr[i] * 2;
            }
            Console.WriteLine("Nhan doi phan tu le: ");
            xuat_Mang(arr, ref n);
        }
        static float tinh_TBC(int[] a)
        {
            int s = 0;
            int d = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0 && a[i] % 2 != 0)
                {
                    s = s + a[i];
                    d = d + 1;
                }
            }

            float t = (float)(s / (d * 1.0));
            return t;
        }


        static void xoaPTTrung(int[] a, ref int so)
        {
            int i, j, k;
            for (i = 0; i < so - 1; i++)
            {
                j = i + 1;
                while (j < so)
                    if (a[i] == a[j])
                    {
                        for (k = j; k < so - 1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        so = so - 1;
                    }
                    else j = j + 1;
            }
            xuat_Mang(a, ref so);
        }
        static void bai_65()
        {
            int[] a = new int[100];
            int so = 0;
            nhap_Mang(ref a, ref so);
            Console.WriteLine("Dãy số:");
            xuat_Mang(a, ref so);
            Console.WriteLine("TBC số nguyên âm lẻ : {0}", tinh_TBC(a));
            Console.Write("\n\n");
            Console.WriteLine("mảng sau khi xóa là:");
            xoaPTTrung(a, ref so);
        }
        static bool check(int[] arr, int size, int x)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == x)
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
            while (i < n)
            {
                
                int x = rand.Next() % 201 - 100;
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


        static void sapXep(int[] a)
        {
            int i, j,t;
            for (i = 0; i < a.Length - 1; ++i) {
                for (j = i + 1; j < a.Length; ++j)
                {
                    if (((a[i] %2 == 0)  && (a[j] % 2 == 0) && (a[i] > a[j])) || (((a[i] % 2 != 0) && (a[j] % 2 != 0) && (a[i] < a[j]))))
                        {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }

                }
            }
                    
            HienMang(a);
        }

        static void bai_67()
        {
            int[] arr;
            nhapMang(out arr);
            HienMang(arr);
            sapXep(arr);

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
                        bai59();
                        break;
                    case 2:
                        bai61();
                        break;
                    case 3:
                        Bai63();
                        break;
                    case 4:
                        bai_65();
                        break;
                    case 5:
                        bai_67();
                        break;
                    default:
                        Console.Write("Mời bạn nhập lại !!!");
                        break;
                }
            }
        }
    }
}
