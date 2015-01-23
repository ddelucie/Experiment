using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public static class Palindrome
	{
		public static bool IsPalindrome(string x)
		{
			//"kayak"
			bool isPalindrome = true;
			char[] arr = x.ToCharArray();
			int length = arr.Length-1;
			for (int i = 0; i < length/2; i++)
			{
				if (arr[i] != arr[length - i])
					return false;
			}
			return true;
		}
	}
}
