using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            String num = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + "번째 수열: " + num);
                char n = num[0];
                int c = 0;
                String num2 = "";

                for (int j = 0; j < num.Length; j++)
                {
                    if (n == num[j])
                        c++;
                    else
                    {
                        // num2 += "" + n + c;
                        num2 += n;
                        num2 += c;
                        n = num[j];
                        c = 1;
                    }
                    if (j + 1 == num.Length)
                    {
                        num2 += n;
                        num2 += c;
                    }
                }
                num = num2;
            }
        }
    }
}
