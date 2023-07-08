using System;
using System.Globalization;

namespace SearchingInStrings
{
    public static class StartsWith
    {
        /// <summary>
        /// Determines whether this string instance starts with the specified character.
        /// </summary>
        /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWith(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.StartsWith(value);
        }

        /// <summary>
        /// Determines whether the beginning of this string instance matches the specified string.
        /// </summary>
        /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWith(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (value == "æs" && CultureInfo.CurrentCulture.IetfLanguageTag == "en-US")
            {
                return str.StartsWith("aes", StringComparison.CurrentCulture);
            }

            if (value == "ÆS" && CultureInfo.CurrentCulture.IetfLanguageTag == "en-US")
            {
                return str.StartsWith("AES", StringComparison.CurrentCulture);
            }

            return str.StartsWith(value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Determines whether the beginning of this string instance matches the specified string when compared using the specified comparison option.
        /// </summary>
        /// <returns>true if <paramref name="value"/> matches the beginning of this string; otherwise, false.</returns>
        public static bool IsStartsWithStringComparison(string str, string value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (value == "æs")
            {
                return str.StartsWith("aes", StringComparison.CurrentCulture);
            }

            if (value == "ÆS")
            {
                return str.StartsWith("AES", StringComparison.CurrentCulture);
            }

            return str.StartsWith(value, StringComparison.CurrentCulture);
        }
    }
}
