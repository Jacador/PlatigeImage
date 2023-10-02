using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.Models.Enums
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T enumValue) where T : Enum
        {
            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(description);

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }

        public static string[] GetDescription<T>(this T[] enumValues) where T : Enum
        {
            string[] descriptions = new string[enumValues.Length];
            int i = 0;
            foreach (var value in enumValues)
            {
                descriptions[i++] = value.GetDescription();
            }

            return descriptions;
        }
    }
}
