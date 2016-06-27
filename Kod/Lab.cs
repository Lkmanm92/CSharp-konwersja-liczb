using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodowanie
{
    class Lab
    {
        private static int[] arabic = { 1000, 500, 100, 50, 10, 5, 1 };
        private static char[] roman = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
        private static int ROMAN_N = arabic.Length;

        private static int MAX_BASE = 20;
        private static String pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        public static String convertTo(int n, int newBase)
        {
            String result = "";

            if (newBase == 1)
            {
                result = arabic2roman(n);
                return result;
            }

            if ((newBase > MAX_BASE) || (newBase < 1))
                return null;

            if (n == 0)
                return "0";

            while (n > 0)
            {
                result = pattern[n % newBase] + result;
                n /= newBase;
            }

            return result;
        }


        private static int valueOf(char x, int baseOfX)
        {
            for (int i = 0; i < baseOfX; i++)
            {
                if (x == pattern[i])
                {
                    return i;
                }
            }
            return -1;
        }


        public static int convertFrom(String n, int baseOfN)
        {
            int i, x;
            int p = 1;
            int result = 0;


            if ((baseOfN > MAX_BASE) || (baseOfN < 2))
                return 0;


            n = n.ToUpper();

            for (i = n.Length - 1; i >= 0; i--)
            {
                x = valueOf(n[i], baseOfN);
                if (x < 0)
                {
                    return 0;
                }
                result += (x * p);
                p *= baseOfN;
            }

            return result;
        }

        //

        public static String arabic2roman(int number)
        {
            int i = 0; //position in arabic and roman arrays

            String result = "";

            if ((number > 3999) || (number <= 0))
            {
                return result;
            }

            while ((number > 0) && (i < ROMAN_N))
            {
                if (number >= arabic[i])
                {
                    number -= arabic[i];
                    result += roman[i];
                }
                else if ((i % 2 == 0) &&
                (i < ROMAN_N - 2) && // 9xx condition
                (number >= arabic[i] - arabic[i + 2]) &&
                (arabic[i + 2] != arabic[i] - arabic[i + 2]))
                {
                    number -= arabic[i] - arabic[i + 2];
                    result += roman[i + 2];
                    result += roman[i];
                    i++;
                }
                else if ((i % 2 == 1) &&
                (i < ROMAN_N - 1) && //4xx condition
                (number >= arabic[i] - arabic[i + 1]) &&
                (arabic[i + 1] != arabic[i] - arabic[i + 1]))
                {
                    number -= arabic[i] - arabic[i + 1];
                    result += roman[i + 1];
                    result += roman[i];
                    i++;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }

        public static int roman2arabic(String number)
        {
            int i = 0, //position in arabic and roman arrays
            j = 0, //position in number
            result = 0,
            length = 0;
            number = number.ToUpper();
            length = number.Length;

            while ((j < length) && (i < ROMAN_N))
            {
                if (number[j] == roman[i])
                {
                    result += arabic[i];
                    j++;
                }
                else if ((i % 2 == 0) &&
                (i < ROMAN_N - 2) && // 9xx condition
                (j < length - 1) &&
                (number[j] == roman[i + 2]) &&
                (number[j + 1] == roman[i]))
                {
                    result += arabic[i] - arabic[i + 2];
                    j += 2;
                    i++;
                }
                else if ((i % 2 == 1) &&
                (i < ROMAN_N - 1) && //4xx condition
                (j < length - 1) &&
                (number[j] == roman[i + 1]) &&
                (number[j + 1] == roman[i]))
                {
                    result += arabic[i] - arabic[i + 1]; 
                    j += 2;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            //there was an error during conversion
            if (i == ROMAN_N)
            {
                result = -1;
            }

            return result;
        }

        public static bool sprawdzRzymska(String f)   // sprawdza rzymska czy poprawna  //
        {
            f = f.ToUpper();
            if (f.Length == 0) return false;
            if (!f.Equals(arabic2roman(roman2arabic(f))) || !sprawdzArabska(roman2arabic(f)))  return false;
            else return true;
        }

        public static bool sprawdzArabska(int e)  // sprawdza arabska czy poprawna  //
        {
            if (e < 1 || e > 3999) return false;
            else return true;
        }

        public static bool sprawdzPodstawe(String x, int podstawa) 
        {
            String c="";
            
            for (int a = 0; a < x.Length; a++) //leci po kazdej literze liczby powiedzmy ze podstawa to 4
            {
                //do podstawa - 1
                for (int b = 0; b < podstawa; b++) //PODSTAWA +1  
                {
                   if (x[a] == pattern[b])
                   {
                       c+=pattern[b];
                   }
                }
            }

            if( x == c) return true;
            else return false;

        }


    }
}
