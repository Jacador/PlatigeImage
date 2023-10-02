using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatigeImage.Models.Enums;

namespace PlatigeImage.View.Utils
{
    public static class RandomUtils
    {
        private const string _allowedChars = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static T GetRandomEnum<T>(this Random random) where T : Enum
        {
            int enumCount = Enum.GetNames(typeof(T)).Length;
            return (T)Enum.ToObject(typeof(T), random.Next(enumCount));
        }

        public static string GetRandomEnumDescription<T>(this Random random) where T : Enum
        {
            T enumValue = random.GetRandomEnum<T>();
            return enumValue.GetDescription();
        }

        public static bool GetRandomBoolean(this Random random)
        {
            return Convert.ToBoolean(random.Next(2));
        }

        public static string GetRandomStringFirstUpper(this Random random, int minLength, int maxLength)
        {
            int length = random.Next(minLength, maxLength);
            return random.GetRandomStringFirstUpper(length);
        }

        public static string GetRandomStringFirstUpper(this Random random, int length)
        {
            if (length == 1) return random.GetRandomString(length).ToUpper();

            return $"{random.GetRandomString(1).ToUpper()}{random.GetRandomString(length - 1).ToLower()}";
        }

        public static string GetRandomString(this Random random, int minLength, int maxLength)
        {
            int length = random.Next(minLength, maxLength + 1);
            return random.GetRandomString(length);
        }

        public static string GetRandomString(this Random random, int length)
        {
            if (length < 0) return string.Empty;

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = _allowedChars[random.Next(_allowedChars.Length)];
            }
            return new string(chars);
        }

        public static string GetRandomNumberString(this Random random, int minLength, int maxLength)
        {
            int length = random.Next(minLength, maxLength + 1);
            return random.GetRandomNumberString(length);
        }

        public static string GetRandomNumberString(this Random random, int length)
        {
            if (length < 0) return string.Empty;

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = Convert.ToChar(random.Next(10) + 48);
            }
            return new string(chars);
        }

        public static double GetRandomDecimal(this Random random, double minValue, double maxValue)
        {
            return minValue + Math.Round(random.NextDouble() * (maxValue - minValue), 2);
        }

        public static T GetRandomFromArray<T>(this Random random, T[] array)
        {
            return array[random.Next(array.Length)];
        }

        public static TKey GetRandomFromDictionaryKeys<TKey, TValue>(this Random random, Dictionary<TKey, TValue> dictionary)
        {
            return dictionary.ElementAt(random.Next(dictionary.Count)).Key;
        }

        public static Random SeedRandom()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }
    }
}
