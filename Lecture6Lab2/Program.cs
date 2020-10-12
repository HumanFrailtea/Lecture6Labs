using System;

namespace Lecture6Lab2
{

	public class Fraction
	{
		private int numerator;
		private int denominator;

		public Fraction()
		{
			numerator = 0;
			denominator = 1;
		}

		public Fraction(int newNumerator)
		{
			numerator = newNumerator;
			denominator = 1;
		}

		public Fraction(int newNumerator, int newDenominator)
		{
			Numerator = newNumerator;
			Denominator = newDenominator;
		}

		public virtual int Numerator
		{
			set
			{
				numerator = value;
			}
			get
			{
				return numerator;
			}
		}

		public virtual int Denominator
		{
			set
			{
				if (value != 0)
				{
					denominator = value;
				}
				else
				{
					denominator = 1;
				}
			}
			get
			{
				return denominator;
			}
		}



		public virtual double FractionValue
		{
			get
			{
				return (double)numerator / denominator;
			}
		}

		public override string ToString()
		{
			reduceFraction();
			return numerator + "/" + denominator;
		}

		public virtual void printFraction()
		{
			reduceFraction();
			Console.WriteLine(numerator + "/" + denominator);
		}

		private void reduceFraction()
		{
			int n = numerator;
			int d = denominator;

			while (n != 0)
			{
				int temp = n;
				n = d % n;
				d = temp;
			}

			numerator = numerator / d;
			denominator = denominator / d;
		}
	}

}
