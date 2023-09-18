namespace TrainSystem
{
    public static class Utilities
    {
        public static bool IsPostiveNonZero(int number)
        {
            if (number <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPostiveNonZero(double number)
        {
            if (number <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsPostiveNonZero(decimal number)
        {
            if (number <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool InHundreds(int number)
        {
            if (number % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InHundreds(double number)
        {
            if (number % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InHundreds(decimal number)
        {
            if (number % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}