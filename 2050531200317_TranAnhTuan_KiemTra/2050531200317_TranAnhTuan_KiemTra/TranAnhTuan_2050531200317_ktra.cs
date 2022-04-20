using System;
using System.Text;

namespace _2050531200317_TranAnhTuan_KiemTra
{
    class Program
    {

        public static void showMenu()
        {
            Console.WriteLine("1. Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.");
            Console.WriteLine("2. Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *");
            Console.WriteLine("3. Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.");
            Console.WriteLine("4. Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)");
            Console.WriteLine("5.Thoát");
        }

        static String getString(string mess)
        {
            Console.Write(mess);
            String value = Console.ReadLine();
            return value;
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
            double a = getDouble("Nhập a = ");
            double b = getDouble("\nNhập b = ");
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
        }


        static void bai2()
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("\n==================================================");
            Console.WriteLine("\n======================*===========================");
            Console.WriteLine("\n=====================***==========================");
            Console.WriteLine("\n===============***************====================");
            Console.WriteLine("\n==================*********=======================");
            Console.WriteLine("\n==================**** ****=======================");
            Console.WriteLine("\n=================***     ***======================");
            Console.WriteLine("\n================*           *=====================");
            Console.WriteLine("\n==================================================");
            Console.WriteLine("\n==================================================");

            Console.WriteLine("\n");

        }

        static void bai3()
        {
            int n, i, j, binno = 0, dn;
            n = getInt("Nhập Một Số Bất Kì: ");
            dn = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }
            Console.Write("\nSố trong hệ nhị phân tương đương của {0} la : {1}.\n\n", dn, binno);
        }

        static void bai4()
        {
            
            String ten = "Trần Anh Tuấn";
            String lop = "20T3";
            String maSV = "2050531200317";
            Console.WriteLine("Họ Tên: {0} \nLớp: {1} \nMã Sinh Viên: {2} " , ten ,lop , maSV);

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
                        bai4();
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        Console.WriteLine("Mời bạn nhập lại !!!");
                        break;
                }
            }
        }
    }
}
