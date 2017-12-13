class GapInPrimes 
{
    public static long[] Gap(int g, long m, long n) 
    {
        long prePrime = 2;
        var result = new long[] { };

        for (var i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                if(i - prePrime == g)
                {
                    result = new long[] { prePrime, i };
                    break;
                }
                else
                {
                    prePrime = i;
                }

                result = null;
            }
        }

        return result;
    }  
    
    public static bool IsPrime(long input)
    {
        if((input & 1) == 0)
        {
            if(input == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        for (var i = 3; (i * i) <= input; i+= 2)
        {
            if((input % i) == 0)
            {
                return false;
            }
        }

        return input != 1;
    }
}
