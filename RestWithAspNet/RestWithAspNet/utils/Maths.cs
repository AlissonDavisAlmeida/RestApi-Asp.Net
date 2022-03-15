namespace RestWithAspNet.utils
{
    public static class Maths
    {
        public static bool IsNumeric(string number)
        {
            int n;
            return int.TryParse(number,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.NumberFormatInfo.InvariantInfo,
                                out n);
        }

        public static decimal ConvertToDecimal(string number)
        {
            decimal value;

            if (decimal.TryParse(number, out value))
            {
                return value;
            }

            return 0;
        }
    }
}