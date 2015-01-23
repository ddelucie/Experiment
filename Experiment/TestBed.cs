using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public static class TestBed
	{
		public static int Factorial(int n)
		{
			if (n == 1) return 1;
			return n * Factorial(n - 1);
		}

		public static int FactorialIterative(int n)
		{
			int answer = 1;
			for (int i = 1; i <= n; i++)
			{
				answer = answer * i;
			}
			return answer;
		}

		public static int MissingNum(int[] nums)
		{
			int a = 1;
			for (int i = 0; i < nums.Length-1; i++)
			{
				if (a < nums[i]) return a;
				a++;
			}
			return a + 1;
		}

		/*
		 dumpList(string str, List list)
		 {
			if (list.Count == 0) return
			object item = list.Remove(list.Index(0))
			if item != type List
		 	{
		 		Console.WriteLine(str + " " + item.Index + item.Value);	
			}
			dumpList(str, list)
		 }
		 
		 

		 * 
		 * 
		 * 
		 * 
		 * 
		 */

	}
}
