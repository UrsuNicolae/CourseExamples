namespace Exemple.Linq
{
    public static class TestExtensions
    {

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        public static bool IsPositive(this int value)
        {
            return value > 0;
        }

        public static bool IsNegative(this int value)
        {
            return value < 0;
        }

        public static bool IsZero(this int value)
        {
            return value == 0;
        }

        public static bool IsNull(this object value)
        {
            return value == null;
        }

        public static bool IsNotNull(this object value)
        {
            return value != null;
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
