using System;
using System.Collections.Generic;
using ChallengeProblems;
using Xunit;

namespace ChallengeProblemsTest
{
	public class StringUtilitiesTest
	{
		[Fact]
		public void ShouldComputeCharacterDistribution()
		{
			String battysSoliloquy = "I've seen things you people wouldn't believe. " +
									 "Attack ships on fire off the shoulder of Orion. " +
									 "I watched C -beams glitter in the dark near the Tannhäuser Gate. " +
									 "All those moments will be lost in time, like tears in rain. Time to die.";

			Dictionary<char, float> characterDistribution = StringUtilities.ComputeCharacterDistribution(battysSoliloquy);
			
			Assert.Equal(0.050, characterDistribution['r'], 2);
			Assert.Equal(0.061, characterDistribution['a'], 2);
			Assert.Equal(0.09497, characterDistribution['i'], 3);
			Assert.Equal(0.0726, characterDistribution['n'], 3);
		}
		
		[Fact]
		public void ShouldFindPalindromes()
		{
			Assert.True(StringUtilities.IsPalindrome("racecar"));
			Assert.False(StringUtilities.IsPalindrome("doofus"));
			Assert.True(StringUtilities.IsPalindrome("murdrum"));
			Assert.False(StringUtilities.IsPalindrome("airplane"));
		}

		[Fact]
		public void ShouldReverseString()
		{
			Assert.Equal("enalpria", StringUtilities.Reverse("airplane"));
			Assert.Equal("radical", StringUtilities.Reverse("lacidar"));
			Assert.Equal("racecar", StringUtilities.Reverse("racecar"));
		}
	}
}