using System;
using System.Collections.Generic;

namespace ChallengeProblems
{
	public static class Maths
	{
		/// <summary>
		/// Computes the factorial of n
		/// </summary>
		/// <param name="n">A number the factorial of which is returned</param>
		/// <returns>The factorial of n</returns>
		public static int Factorial(int n)
		{
			if (n == 0)
			{
				return 0;
			}
			else if (n == 1)
			{
				return 1;
			}
			else
			{
				return n * (Factorial(n - 1));
			}
		}
		
		/// <param name="numbers">The integers to be averaged</param>
		/// <returns>The average of all the integers in numbers</returns>
		public static float Average(List<int> numbers)
		{
			throw new Exception("Average() doesn't do anything yet!");
		}

		/// <returns>The result of raising n to the power given by the power argument</returns>
		public static int RaiseToPower(int n, int power)
		{
			int result = 1;

			for (int i = 0; i < power; i++)
			{
				result = result * n;
			}

			return result;
		}
	}
}