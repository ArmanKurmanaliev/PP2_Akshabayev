using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexApp
{
    class Complex
    {
        public int a, b;
        public Complex() { }
        public Complex(int x, int y)
        {
            this.a = x;
            this.b = y;
        }

        // this->cmp1, c -> cmp2
        public Complex Add(Complex c)
        {
            Complex res = new Complex(this.a + c.a, this.b + c.b);
            // res = new Complex(6, 8);
            // res.a = 6
            // res.b = 8
            return res;

        }

        public static int Gcd1(int a, int b)
        {
            int m = Math.Max(a, b);
            int n = Math.Min(a, b);
            if (n != 0)
            {
                return Gcd1(n, m % n); // 8 3, 3 
            }
            return m;
        }

        public static int Lcm(int a, int b)
        {
            return a * b / Gcd1(a, b);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            int q = Lcm(c1.b, c2.b);
            Complex res = new Complex((q / c2.b * c2.a) + (q / c1.b * c1.a), q);
            res.Simplify();
            return res;
        }

        // 2/4 - 3/8 = 1/8

        public static Complex operator -(Complex c1, Complex c2)
        {
            int m = Lcm(c1.b, c2.b);
            Complex res = new Complex((m / c1.b * c1.a) - (m / c2.b * c2.a), m);
            //res.Simplify();
            return res;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a * c2.a, c1.b * c2.b);
            res.Simplify();
            return res;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a * c2.b, c1.b * c2.a);
            res.Simplify();
            return res;
        }

        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;

            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            // _a = 0, _b = 0 gcd(a, b) = _a + _b
            int gcd = _a + _b;
            this.a /= gcd;
            this.b /= gcd;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}