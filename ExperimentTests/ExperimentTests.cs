using System;
using System.Collections.Generic;
using Experiment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
	[TestClass]
	public class ExperimentTests
	{

		[TestMethod]
		public void TestFactorial()
		{
			Assert.AreEqual(1, TestBed.Factorial(1));
			Assert.AreEqual(2, TestBed.Factorial(2));
			Assert.AreEqual(6, TestBed.Factorial(3));
			Assert.AreEqual(120, TestBed.Factorial(5));


			Assert.AreEqual(1, TestBed.FactorialIterative(1));
			Assert.AreEqual(2, TestBed.FactorialIterative(2));
			Assert.AreEqual(6, TestBed.FactorialIterative(3));
			Assert.AreEqual(120, TestBed.FactorialIterative(5));
		}

		[TestMethod]
		public void TestBinaryConverter()
		{
			string answer;

			answer = BinaryConverter.Convert(2);
			Console.WriteLine(answer);
			Assert.AreEqual(10, Int32.Parse(answer));

			answer = BinaryConverter.Convert(3);
			Console.WriteLine(answer);
			Assert.AreEqual(11, Int32.Parse(answer));

			answer = BinaryConverter.Convert(4);
			Console.WriteLine(answer);
			Assert.AreEqual(100, Int32.Parse(answer));

			answer = BinaryConverter.Convert(5);
			Console.WriteLine(answer);
			Assert.AreEqual(101, Int32.Parse(answer));

			answer = BinaryConverter.Convert(15);
			Console.WriteLine(answer);
			Assert.AreEqual(1111, Int32.Parse(answer));

			answer = BinaryConverter.Convert(15);
			Console.WriteLine(answer);
			Assert.AreEqual(1111, Int32.Parse(answer));

			answer = BinaryConverter.Convert(133);
			Console.WriteLine(answer);
			Assert.AreEqual(10000101, Int32.Parse(answer));
		}

		


		public void TestSets()
		{
			ISet<int> set = CollectionPlayground.SetMerge();
			foreach (var i in set)
			{
				Console.WriteLine(i);
			}
		}


		public void TestReadOnlyListCreate()
		{
			IReadOnlyList<string> set = CollectionPlayground.ReadOnlyListCreate();
			foreach (var i in set)
			{
				Console.WriteLine(i);
			}
		}
	}
}
