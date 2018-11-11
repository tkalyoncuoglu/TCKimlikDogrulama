

using System;
using System.Linq;


namespace TurkishId
{
    public class TurkishIdNumber
    {
        public const int Length = 11;

        public static bool IsValid(string number)
        {
            if (number == null || number.Length != Length)
            {
                return false;
            }

            if(!number.All(x => char.IsNumber(x)))
            {
                return false;
            }

            var k = number.Select(x => x.ToString()).Select(x => Convert.ToInt32(x)).ToList();

            if (k[0] <= 0)
            {
                return false;
            }

            var d10firstPart = k.Where((x, i) => i % 2 == 0 && i < 9).Sum(x => x * 7);

            var d10secondPart = k.Where((x, i) => i % 2 != 0 && i < 9).Sum();

            var d10 = (d10firstPart - d10secondPart + 10) % 10;

            if (k[9] != d10)
            {
                return false;
            }

            var d11 = k.Where((x, i) => i < 10).Sum() % 10;

            if (k[10] != d11)
            {
                return false;
            }

            return true;

        }

       
    }
}