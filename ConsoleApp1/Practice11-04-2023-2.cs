using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rational
    {
        private int _numerator,_denominator;

        public Rational(int numerator,int denominator)
        {
            this._numerator = numerator;
            this._denominator = denominator;    
        }

        public int Numerator { get { return _numerator; }  }

        public int Denominator { get { return _denominator; } }

        public int Sign { get { return (_numerator == 0 ? 0 : (_numerator < 0) ? -1 : 1); } }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static Rational operator +(Rational a) => a;
        public static Rational operator -(Rational a) => new Rational(-a.Numerator, a.Denominator);

        public static Rational operator +(Rational left, Rational right)
               => new Rational(left.Numerator * right.Denominator + right.Numerator * left.Denominator, left.Denominator * right.Denominator);
        

        public static Rational operator -(Rational left, Rational right)
                => left + (-right);

        public static Rational operator *(Rational a, Rational b)
        => new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Rational(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }


        public static bool operator ==(Rational a, Rational b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }
            a.Reduce();
            b.Reduce();
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Rational other = (Rational)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() ^ Denominator.GetHashCode();
        }

       

        private void Reduce()
        {
            if (Denominator < 0)
            {
                _numerator = -Numerator;
                _denominator = -Denominator;
            }
            int gcd = GCD(Numerator, Denominator);
            _numerator /= gcd;
            _denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return Math.Abs(a);
        }

        public static bool operator <(Rational a, Rational b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static bool operator >(Rational a, Rational b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return a.Numerator * b.Denominator <= b.Numerator * a.Denominator;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return a.Numerator * b.Denominator >= b.Numerator * a.Denominator;
        }
    }
}
