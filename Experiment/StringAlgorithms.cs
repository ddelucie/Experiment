using System;
using System.Linq;

namespace Experiment
{
	public static class StringAlgorithms
	{
		//determine if string has unique chars without using any data structure
		public static bool HasUniqueChars(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				char c = s.ElementAt(i);
				string reducedString = s.Remove(i);
				if (reducedString.Contains(c)) return false;
			}
			return true;
		}


		public static bool IsAnagram(string s1, string s2)
		{
			char[] a1 = s1.ToCharArray();
			char[] a2 =s2.ToCharArray();
			Array.Sort(a1);
			Array.Sort(a2);


			return (a1.SequenceEqual(a2));

		}

	}
}
