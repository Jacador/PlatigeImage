using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.Validators
{
    public static class TinValidator
    {
        public static bool IsValid(string tin)
        {
            if (tin.Length == 0) return true;

            tin = tin.Replace("-", string.Empty);

            if (tin.Length != 10 || tin.Any(chr => !Char.IsDigit(chr)))
                return false;

            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7, 0 };
            int sum = tin.Zip(weights, (digit, weight) => (digit - '0') * weight).Sum();

            return (sum % 11) == (tin[9] - '0');
        }
    }
}
