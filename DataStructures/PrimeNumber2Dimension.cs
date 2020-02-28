using System;

namespace DataStructures
{
    class PrimeNumber2Dimension
    {
        public PrimeNumber2Dimension()
        {
        }
        public static void DriverMethod()
        {
            PrimeNumber2Dimension p = new PrimeNumber2Dimension();
            int[,] arr=p.Fill2DArray();
            p.displayArray(arr);
        }
        public  bool IsPrime(int num)
        {
            int count = 1, i = 2;
            if (num==1 || num == 0) return false;
            while(num/2>=i)
            {       
                if (num % i == 0)
                    count++;
                if (count >= 2)
                    return false;
                i++;
            }
            return true;
        }
        public int countPrime(int m,int n)
        {
            int count = 0;
            if(m>n)
            {
                int t = m;
                m = n;
                n = t;
            }
            for(int i=m;i<=n;i++)
            {
                if(IsPrime(i))count++;
            }
            return count;
        }
        public int[,] Fill2DArray()
        {
            int[,] array = new int[20, 30];
            int m = 0, n = 100;
            for(int i=0;i<array.GetLength(0) && n<=1001;i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = m, k = 0; j < n; j++)
                    {
                        if (IsPrime(j))
                        {
                            array[i, k++] = j;
                        }
                    }
                    m = n; n = n + 100;
                }
                else
                { array[i, 0] = m; array[i, 1] = n; }
            }
            return array;
        }
        public void displayArray(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(a[i, 0] + " " + a[i, 1]);
                }
                else
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] != 0)
                        {
                            Console.Write(a[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
