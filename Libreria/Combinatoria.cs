using System;
using System.Numerics;

namespace Libreria
{
    public class Combinatoria
    {
        public static BigInteger Fattoriale(int n)
        {
            BigInteger fatt = new BigInteger(1);
            for (int i = n; i > 0; i--)
            {
                fatt *= i;
            }
            return fatt;
        }
    }
}
