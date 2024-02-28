using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caudieukien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Giải phương trình bậc nhất: a * x + b = 0. Với a, b được nhập từ bàn phím.");
            Console.WriteLine("---------------------------");
            Console.Write("Nhập giá trị của a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị của b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Phương trình bậc nhật là: {0} * x + {1} = 0", a, b);
            float x ;
            x = -b / a;
            if (a != 0)
            {
                Console.WriteLine("Phương trình có nghiệm là x = {0}", x);
            }
            else
            {
                if ( b == 0 )
                {
                    Console.WriteLine("Phương trình luôn đúng với mọi x");
                }else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            Console.ReadKey();
        }
    }
}
