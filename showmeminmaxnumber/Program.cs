using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String a2;
            int[] a = new int[5];
            int max = 0, min = 0;


            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                a2 = Console.ReadLine();
                a[i] = Convert.ToInt32(a2);
            }

            for(int i=0; i<5; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            min = a[0];
            for(int i = 0; i < 5; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("가장 큰 수: %d", max);
            Console.WriteLine("가장 작은 수: %d", min);
        }
    }
}
