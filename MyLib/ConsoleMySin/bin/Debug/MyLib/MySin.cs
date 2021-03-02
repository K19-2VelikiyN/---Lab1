using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    ///Обчислення математичних функцій

    public class MySin
    {
       public static int Sin(int A, int B, int C)
        {
            int result;
            int S1, S2;
            S1 = A * B;
            S2 = S1 / 6;
            result = S2 / C;
            return result;
        }
        public static double Sin1(int n, double x)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + (Math.Cos(2 * i * x) / i);
            }
            
            return s;
        }
    }
}
