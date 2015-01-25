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
	}
}
