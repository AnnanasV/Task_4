namespace MathHelper
{
    public static class MathHelper
    {
        public static int Factorial(int n)
        {
            if (n == 0) return 1; // 0! = 1
            int fact = n;
            for (int i = n - 1; i > 0; i--) // n-1 'couse we do not need multiply number by itself
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}