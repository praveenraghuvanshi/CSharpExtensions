using System.Text.RegularExpressions;

namespace Extensions
{
    /// <summary>
    /// Extensions to <see cref="string"/> type.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Validates if a zipcode is valid or not.
        /// </summary>
        /// <param name="zipcode">Zipcode to be validated.</param>
        /// <returns>True, if zipcode is valid.</returns>
        public static bool IsValidZipCode(this string zipcode)
        {
            if (string.IsNullOrWhiteSpace(zipcode))
            {
                return false;
            }

            // US Zipcode
            var usZipcodeRegex = GetUSZipcodeRegex();

            if (usZipcodeRegex.IsMatch(zipcode))
            {
                return true;
            }

            return false;
        }

        private static Regex GetUSZipcodeRegex()
        {
            return new Regex("^[0-9]{5}(-[0-9]{4})?$");
        }
    }
}
