using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string bazard = "";
            string tempo = "";
            int count = 0;
            int size = input.Length;
            for(int i = 0; i<size;i++)
            {
                if (count % 2 == 0) { bazard += input[i]; }
                else { tempo+= input[i]; }
                count++;
            }
            bazard += tempo;
            return bazard;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if(input == null) return true;
            int size = input.Length;
            for (int i = 0; i < size; i++)
            {
                if (input[i] != ' ') { return false; }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if (IsNullEmptyOrWhiteSpace(a) == true) throw new ArgumentException();
            if (IsNullEmptyOrWhiteSpace(b) == true) throw new ArgumentException();
            string mix = "";
            int sizeA = a.Length;
            int sizeB = b.Length;
            for (int i = 0; i<sizeA + sizeB; i++)
            {
                if (i < sizeA) { mix += a.ElementAt(i); }
                if (i < sizeB) { mix += b.ElementAt(i); }
            }
            return mix;
        }

        public static string Reverse(string a)
        {
            string esrever = "";
            int size = a.Length;
            for (int i = size-1; i>=0; i--)
            {
                esrever += a[i];
            }
            return esrever;
               
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            int size = a.Length;
            string mix = "";
            for (int i = 0; i < size; i++)
            {
                if (a[i] >= 65 && a[i] <= 90) { mix += Convert.ToChar(a.ElementAt(i) + 32); }
                else if (a[i] == 'É') { mix += 'é'; }
                else { mix += a[i]; }; 
            }
            return mix;
            throw new NotImplementedException();
        }

        public static string UnBazardString(string input)
        {
            string final = "";
            string bazard = "";
            string tempo = "";
            int size = input.Length;
            for (int i = 0; i < size/2; i++)
            {
                bazard += input[i];
            }
            for (int i = 0; i < size/2; i++)
            {
                tempo += input[i + size/2];
            }
            for (int i = 0; i < size/2; i++)
            {
                final += bazard[i];
                final += tempo[i];
            }
            return final;
        }

        public static string Voyelles(string a)
        {
            string aeiou = "";
            int size = a.Length;
            a = ToLowerCase(a);
            for (int i = 0; i<size; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u') 
                {
                    if (!aeiou.Contains(a[i])) { aeiou += a[i]; }
                }
            }
            return aeiou;
        }
    }
}
