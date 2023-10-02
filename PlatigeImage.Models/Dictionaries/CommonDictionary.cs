using PlatigeImage.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.Models.Dictionaries
{
    public class CommonDictionary
    {
        public static Dictionary<PaymentMethod, string> PaymentMethods()
        {
            return new Dictionary<PaymentMethod, string>()
            {
                {PaymentMethod.Cash, "Cash"},
                {PaymentMethod.Card, "Card"},
                {PaymentMethod.Transfer, "Transfer"},
                {PaymentMethod.Check, "Check"},
            };
        }

        public static Dictionary<double, string> VatRates()
        {
            return new Dictionary<double, string>()
            {
                {0.23, "23%"},
                {0.08, "8%"},
                {0.05, "5%"},
                {0.00, "0%"},
            };
        }
    }
}
