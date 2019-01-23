using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  Key:
 *  M = 1000
 *  D = 500
 *  C = 100
 *  L = 50
 *  X = 10
 *  V = 5
 *  I = 1
 * 
 *  Special Cases:
 *  CM = 900
 *  CD = 400
 *  XC = 90
 *  XL = 40
 *  IX = 9
 *  IV = 4
 */

namespace RomanNumeralConverter
{
    public class Converter
    {
        static void Main()
        {

        }

        public int RomanToInt(string romanString)
        {
            if (romanString == String.Empty || romanString.Length > 14)
            {
                throw new ArgumentOutOfRangeException("Input must be valid roman numeral.");
            }
            int result = 0;
            string k = romanString.ToUpper();

            // Loop string input
            foreach (char c in k)
            {
                result += convertSymbol(c);
            }

            // Handle special cases. 
            // Contains method is sequential/linear O(n) search method. 
            if (k.Contains("CM") || k.Contains("CD"))
            {
                result -= 200;
            }
            if (k.Contains("XC") || k.Contains("XL"))
            {
                result -= 20;
            }
            if (k.Contains("IX") || k.Contains("IV"))
            {
                result -= 2;
            }
            if ((result == 0) || (result > 3999))
            {
                throw new ArgumentOutOfRangeException("Input must be valid roman numeral.");
            }
            return result;
        }

        internal int convertSymbol(char c)
        {
            if (c == 'M') return 1000;
            if (c == 'D') return 500;
            if (c == 'C') return 100;
            if (c == 'L') return 50;
            if (c == 'X') return 10;
            if (c == 'V') return 5;
            if (c == 'I') return 1;

            else return 0;
        }
    }
}
