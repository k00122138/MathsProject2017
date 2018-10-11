using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathsGui
{
    class maths
    {

        public maths() { }

        public int Multiples(int n)
        {


            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum += i;
                }
                else if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public List<BigInteger> PrimeFactors(BigInteger n)
        {

            BigInteger length;
            List<BigInteger> vectors = new List<BigInteger>();
            length = Isqrt(n);


            for (BigInteger i = 2; i < length; i++)
            {
                while (n % i == 0)
                {
                    vectors.Add(i);
                    n = n / i;
                    length = Isqrt(n);

                }


            }

            return vectors;

        }
        private BigInteger Isqrt(BigInteger num)
        {
            if (0 == num) { return 0; }  // Avoid zero divide  
            BigInteger n = (num / 2) + 1;       // Initial estimate, never low  
            BigInteger n1 = (n + (num / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (num / n)) / 2;
            } // end while  
            return n;
        }


        public int fibb(int n)
        {


            int k = 0;
            int j = 1;
            int f = 0;
            int sum = 0;

            for (; f < n; )
            {
                
                k = j;
                j = f;
                if (f % 2 == 0)
                {
                    sum += f;
                }
                f = j + k;
            }
            return sum;
        }
        public BigInteger euclidian(BigInteger a, BigInteger b)
        {
            if (a < b)
            {
                return 0;
            }
            else
            {
                BigInteger[] varr = { b, 0, 1 };
                BigInteger[] uarr = { a, 1, 0 };
                BigInteger[] warr = { 0, 0, 0 };
                BigInteger d, x, y;
                BigInteger aa;
                while (varr[0] > 0)
                {
                    aa = (uarr[0] / varr[0]);
                    for (int i = 0; i < 3; i++)
                    {
                        warr[i] = uarr[i] - (aa * varr[i]);
                        uarr[i] = varr[i];
                        varr[i] = warr[i];
                    }

                }
                d = uarr[0];
                x = uarr[1];
                y = uarr[2];
                if (d == (a * x + b * y))
                {
                    return d;
                }
                else
                {
                    return 0;
                }
            }

        } 
        public BigInteger encrypt(BigInteger p , BigInteger q, BigInteger P)
        {
            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger a = Isqrt(phi);

            int rand = (int)a;


            BigInteger e;

            Random r = new Random();

            e = r.Next(5, rand);
            while(euclidian(phi, e) != 1)
            {
                e = r.Next(5, rand);
            }
            
            return 0;
        }
        
    }
}



