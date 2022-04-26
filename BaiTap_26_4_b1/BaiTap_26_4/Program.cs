using System;

namespace BaiTap_26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PTB2 tB2_317 = new PTB2();
            Console.WriteLine(" nhap a_317 = ");
            float a_317 = float.Parse(Console.ReadLine());
            Console.WriteLine(" nhap b_317 = ");
            float b_317 = float.Parse(Console.ReadLine());
            Console.WriteLine(" nhap c_317 = ");
            float c_317 = float.Parse(Console.ReadLine());
            tB2_317.nghiem(a_317, b_317, c_317);
            Console.ReadKey();
        }
    }
}
