
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }

        private static int PowerUp(int N, int Pow)
        {
            if (Pow == 0)
            {
                return 1;
            }
            else
            {
                if (Pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --Pow);
                }
            }
        }
    }
}
