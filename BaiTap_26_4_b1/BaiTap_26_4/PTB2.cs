using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_26_4
{
    class PTB2
    {
        private float a;
        private float b;
        private float c;

        public PTB2()
        {
        }

        public PTB2(float a, float b, float c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }


        public float a1 { get; set; }
        public float b1 { get; set; }
        public float c1 { get; set; }


        public float denta(float a , float b , float c)
        {
            return (b * b) - (4 * a * c);
        }


        public void nghiem(float a_317, float b_317, float c_317)
        {
            if (denta(a_317,b_317,c_317) > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b_317 - Math.Sqrt(denta(a_317, b_317, c_317)) / 2 * a_317)));
                Console.WriteLine("X2 = {0}", ((-b_317 + Math.Sqrt(denta(a_317, b_317, c_317))) / 2 * a_317));

            }
            else if (denta(a_317, b_317, c_317) == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b_317 / 2 * a_317);
            }
            else if (denta(a_317, b_317, c_317) < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }



    }
}
