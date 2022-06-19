namespace Test1Library
{
    public class PrimeChecker
    {

        public NumberType IsPrime(int x)
        {
            if (x <= 1)
                return NumberType.Other;

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return NumberType.Composite;
            }

            return NumberType.Prime;
        }

        public enum NumberType
        {
            Prime,
            Composite,
            Other
        }
    }
}