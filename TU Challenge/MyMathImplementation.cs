using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 2;  i<=a; i++) 
            {
                if (IsPrimary(i) == true) list.Add(i);
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            else return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static int IsInOrder(int a, int b)
        {
            if(a>b) return -1;
            else if(a<b) return 1;
            else return 0;

        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if(IsInOrder(arg1,arg2) == -1) return arg2;
            else if(IsInOrder(arg1, arg2) == 1) return arg1;
            throw new ArgumentException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            int size = list.Count;
            for (int i = 0; i < size - 1; i++)
            {
                if (IsInOrder(list[i], list[i+1]) == -1) { return false; }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {

            if (age < 0 || age >= 150) { throw new ArgumentException(); }
            else if (age >= 18) { return true; }
            else { return false; }
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) { return false; }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i<b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a*a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            int tempo;
            int size = toSort.Count;
            do
            {
            for (int i = 0; i < size-1; i++) 
            {
                    tempo = IsInOrderDesc(toSort[i], toSort[i + 1]);
                    if (tempo != toSort[i]) { toSort[i + 1] = toSort[i]; toSort[i] = tempo; }
            }
            }while(IsListInOrder(toSort) == false);
            return toSort;
        }
    }
}
