using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace ChallengeProblems
{
	public static class StringUtilities
	{
		/// <summary>
		/// This method computes the distribution of each character in a string of text. That is, it determines,
		/// out of the total number of characters in the screen, what percentage of the total is made up of each character.
		/// For example, in the string "here", 'e' represents 0.50, or 50%, of all characters.
		///
		/// The return value is a Dictionary (i.e. a hashmap) where the keys are each character that appeared in the string,
		/// and the values are the percentage of the string made up by each character. For example, for the string "here",
		/// ComputeCharacterDistribution() would return a Dictionary with the values { {'e', 0.5}, {'h', 0.25}, {'r', 0.25} }
		///
		/// ComputeCharacterDistribution() is not case sensitive. In other words, it treats 'A' the same as 'a', and the string
		/// "Eel" would be computed as being made up of 0.67 'e' and 0.33 'l'. All characters in the Dictionary it returns will be
		/// lower case.
		/// </summary>
		/// <returns>A Dictionary (i.e. a hashmap) where the keys are each character that appeared in the string,
		/// and the values are the percentage of the string made up by each character.</returns>
		public static Dictionary<char, float> ComputeCharacterDistribution(String text)
		{
			text = text.ToLower();
			text = Clean(text);
			
			var distribution = new Dictionary<char, float>();

			IDictionary<char, uint> counts = ComputeCharacterCounts(text);

			decimal totalCharacters = text.Length;
			
			foreach (KeyValuePair<char,uint> count in counts)
			{
				decimal countValue = count.Value;
				distribution[count.Key] = (float) (countValue / totalCharacters);
			}

			return distribution;
		}
		

		/// <param name="word">The String to check</param>
		/// <returns>true if word is a palindrome, false if not</returns>
		public static bool IsPalindrome(String word)
		{
			if (word.Length == 0)
			{
				return false;
			}
			if (word.Length == 1)
			{
				return true;
			}
			else if (word.Length == 2)
			{
				return word[0] == word[1];
			}
			else
			{
				if (word[0] == word[word.Length - 1])
				{
					int newLength = word.Length - 2;
					string trimmedWord = word.Substring(1, newLength);
					return IsPalindrome(trimmedWord);
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Creates a new String that is the reverse of word. For example, for the argument "lots", Reverse()
		/// will return "stol"
		/// </summary>
		/// <param name="word">The string to reverse</param>
		/// <returns>The reverse of word</returns>
		public static String Reverse(String word)
		{
			StringBuilder reverseWordBuilder = new StringBuilder();

			for (int i = 0; i < word.Length; i++)
			{
				char c = word[word.Length - 1 - i];
				reverseWordBuilder.Append(c);
			}

			return reverseWordBuilder.ToString();
		}
		
		/// <summary>
		/// Removes all vowels (excluding 'y') from a string, so that, for example, "happy birthday" becomes
		/// "hppy brthdy"
		/// </summary>
		/// <param name="word">The word the vowels of which are to be removed</param>
		/// <returns>The input string with all vowels removed</returns>
		public static String RemoveVowels(String word)
		{
			throw new Exception("RemoveVowels() doesn't do anything yet!");			
		}
		
		/// <summary></summary>
		/// <returns>A Dictionary (i.e. a hashmap) where the keys are each character that appeared in the string,
		/// and the values are the number of times that character appears in the String text.</returns>
		public static IDictionary<char, uint> ComputeCharacterCounts(String text)
		{
			var counts = new SortedDictionary<char, uint>();

			text = Clean(text);

			foreach (char character in text)
			{
				if (counts.ContainsKey(character))
				{
					counts[character] = counts[character] + 1;
				}
				else
				{
					counts[character] = 1;
				}
			}

			return counts;
		}
		
		/// <summary>
		/// Removes all characters from a String that aren't the letters 
		/// </summary>
		/// <param name="text"></param>
		/// <returns>A clean string</returns>
		public static String Clean(String text)
		{
			var originalString = new String(text);
			var cleanStringBuilder = new StringBuilder("");
			
			var allowedCharacters = new HashSet<char>
			{
				'a', 'b', 'c', 'd', 'e', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
				'A', 'B', 'C', 'D', 'E', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
			};

			foreach (char character in originalString)
			{
				if (allowedCharacters.Contains(character))
				{
					cleanStringBuilder.Append(character);
				}
			}

			string cleanString = cleanStringBuilder.ToString();
			return cleanString;
		}
	}
}