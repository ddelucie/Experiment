using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	internal class Program
	{

		private static string result;

		private static void Main()
		{
			SaySomething();
			Console.WriteLine(result); Console.ReadKey();
		}

		private static async Task<string> SaySomething()
		{
			await Task.Delay(5);
			result = "Hello world!";
			return "Something";
		}


		//private static void Main(string[] args)
		//{
		//	Console.WriteLine(Palindrome.IsPalindrome("kayak"));
		//	Console.ReadKey();
		//}

		private static void Main3(string[] args)
		{
			BaseClass obj1 = new BaseClass();
			BaseClass obj2 = new InheritedClass();

			Console.WriteLine(obj1.Name());
			Console.WriteLine(obj2.Name());


			obj2 = new BaseClass();
			Console.WriteLine(obj2.Name());


			Console.ReadKey();

		}

		private static void Main1(string[] args)
		{
			int[] nums = new int[] {1, 2, 3, 5, 6, 7, 8, 9};
			int a = TestBed.MissingNum(nums);
			Console.WriteLine(a);
			Console.ReadKey();

		}

		private static void Main2(string[] args)
		{
			MyBase myBase = new MyBase();


			MyDerived myDerived = new MyDerived();

			Console.WriteLine(myDerived.i);
			Console.WriteLine(myBase.i);
			Console.ReadKey();
		}
	}
}
