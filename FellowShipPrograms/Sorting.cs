using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sorting
    {
        public static void InsertionSortInt(int[] ar)
        {
            for (int i = 1; i < ar.Length; i++)
            {

                int t = ar[i];
                int j = i - 1;
                while (j >= 0 && ar[j] > t)
                {
                    ar[j + 1] = ar[j];
                    j--;
                }
                ar[j + 1] = t;
            }
        }
        public static void BubbleSortDownInt(int[] ar)
        {
            for(int i=0;i<ar.Length-1;i++)
            {
                for(int j=0;j<=ar.Length-i-1;j++)
                {
                    if(ar[i]>ar[j])
                    {
                        int t = ar[i];
                        ar[i] = ar[j];
                        ar[j] = t;
                    }
                }
            }
        }
       
        public static void BubbleSortUpInt(int[] ar)
        {
            for(int i=0;i<ar.Length-1;i++)
            {
                for(int j=i+1;j<ar.Length-i-1;j++)
                {
                    if (ar[j + 1] > ar[j])
                    {
                        int t = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = t;
                    }
                }
            }
        }
        public static void BubbleSortString(String[] ar)
        {
            for(int i=0;i<ar.Length-1;i++)
            {
                for(int j=0;j<ar.Length-i-1;j++ )
                {
                    if(ar[j+1].CompareTo(ar[j])<0)
                    {
                        string t = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = t;
                    }
                }
            }
        }
        public static void BubbleSortChar(char[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = 0; j < ar.Length - i - 1; j++)
                {
                    if (ar[j + 1].CompareTo(ar[j]) < 0)
                    {
                        char t = ar[j + 1];
                        ar[j + 1] = ar[j];
                        ar[j] = t;
                    }
                }
            }
        }
        public static int IntBinarySearch(int[] ar,int search )
        {
            int l = 0, h = ar.Length - 1,m = (l + h) / 2;
            while(l<=h)
            {
                if (ar[m] == search)
                    return m;
                else if (ar[m] > search)
                    h = m - 1;
                else
                    l = m + 1;
                m=(l+h)/ 2;
            }
            return -1;
        }
        public static int StringBinarySearch(String[] ar,string search)
        {
            int l = 0, h = ar.Length - 1, m = (h + l) / 2;
            while (l <= h)
            {
                if (ar[m].Equals(search))
                { return m; }
                else if (ar[m].CompareTo(search) < 0)
                { l = m + 1; }
                else { h = m - 1; }
                m = (l + h) / 2;
            }
            return -1;
        }

    }
}
