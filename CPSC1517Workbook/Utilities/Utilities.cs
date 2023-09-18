namespace Utils
{
    public static class Utilities
    {
        public static bool IsZeroOrNegative(int value)
        {
            //Simple method
            return value <= 0;

            //Explicit method
            //bool result;

            //if (value <= 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}

            //return result;

            //Simple explicit using terniary operator
            //return value <= 0 ? true : false;
        }

        public static bool isPositive(int value) => value > 0;
        public static bool IsNullEmptyOrWhitespace(string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        // Expression-bodied method
        //public static bool IsNullEmptyOrWhitespace(string value) => String.IsNullOrWhiteSpace(value);

        public static bool IsInTheFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}