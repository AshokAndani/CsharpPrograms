using System;

namespace DataStructures
{
    class BinarySearchTree
    {
        public static int fact(int n)
        {
            int result = 1;
            while (n > 0)
            {
                result *= n--;
            }
            return result;
        }

        public static int BinomialCo(int n, int k)
        {
            if (k > n - k) k = n - k;
            int nn = fact(n);
            int kk = fact(k);
            int fin = fact(n - k);
            return (nn / (kk * fin));
        }
        public static int CatalanNumber(int n)
        {
            return ((fact(2*n)/((fact(n+1)*(fact(n))))));
        }
        public static int catalan(int n)
        {
            int c = BinomialCo(2 * n, n);
            return c / (n+1);
        }
        public static int countBST(int n)
        {
            return catalan(n);
        }
        public static void DriverMethod()
        {
            Console.WriteLine("enter the number of Nodes");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Binary Search tree for "+number
                +" nodes are "+countBST(number));
        }
    }
}
