using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfNNumbers
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            if(1 <= n && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j <= i + n; j++)
                    {
                        if (j == i + n)
                        {
                            Console.Write(j);
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
