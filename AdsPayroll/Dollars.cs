using System;
using System.Collections.Generic;
using NodaMoney;

namespace AdsPayroll
{
    public class Dollars : IComparable<Dollars>
    {
        private Money money;

        public Dollars(Decimal amount)
        {
            money = Money.USDollar(amount);
        }

        public Dollars(Money aMoney)
        {
            money = aMoney;
        }

        public static Dollars Parse(string aString)
        {
            var aMoney = Money.Parse("$" + aString);
            return new Dollars(aMoney);
        }

        protected bool Equals(Dollars otherDollars)
        {
            return money.Equals(otherDollars.money);
        }

        private bool MoneyEquals(Money otherMoney)
        {
            return this.money.Equals(otherMoney);
        }

        public string ToCleanString()
        {
            var dirtyString = money.ToString();
            var cleanString = dirtyString.Remove(0, 1);
            return cleanString;
        }

        private sealed class MoneyEqualityComparer : IEqualityComparer<Dollars>
        {
            public bool Equals(Dollars x, Dollars y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.money.Equals(y.money);
            }

            public int GetHashCode(Dollars obj)
            {
                return obj.money.GetHashCode();
            }
        }

        public static IEqualityComparer<Dollars> MoneyComparer { get; } = new MoneyEqualityComparer();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Dollars) obj);
        }

        public override int GetHashCode()
        {
            return money.GetHashCode();
        }

        public new string ToString()
        {
            return money.ToString();
        }

        public bool IsGreaterThan(Dollars otherDollars)
        {
            return otherDollars.IsGreaterThan(money);
        }

        private bool IsGreaterThan(Money otherDollars)
        {
            return otherDollars > money;
        }

        public int CompareTo(Dollars other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return money.CompareTo(other.money);
        }

        public static bool operator <(Dollars left, Dollars right)
        {
            return Comparer<Dollars>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(Dollars left, Dollars right)
        {
            return Comparer<Dollars>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(Dollars left, Dollars right)
        {
            return Comparer<Dollars>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(Dollars left, Dollars right)
        {
            return Comparer<Dollars>.Default.Compare(left, right) >= 0;
        }

        public static Dollars operator -(Dollars leftDollars, Dollars rightDollars)
        {
            return new Dollars(leftDollars.money - rightDollars.money);
        }

        public static Dollars operator +(Dollars dollars, Dollars otherDollars)
        {
            return new Dollars(dollars.money + otherDollars.money);
        }

        public static Dollars operator *(Dollars multiplicand, Decimal multiplier)
        {
            return new Dollars(multiplicand.money * multiplier);
        }

        public static Dollars operator *(Dollars multiplicand, int multiplier)
        {
            return new Dollars(multiplicand.money * multiplier);
        }

        public static Dollars operator *(Dollars multiplicand, Double multiplier)
        {
            return new Dollars(multiplicand.money * (decimal) multiplier);
        }

        public static Dollars Zero()
        {
            return Dollars.Parse("0.00");
        }
    }
}