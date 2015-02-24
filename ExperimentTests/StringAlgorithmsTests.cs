using Experiment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
	[TestClass]
	public class StringAlgorithmsTests
	{
		[TestMethod]
		public void TestHasUniqueChars()
		{
			string input;
			bool result;

			input = "nonunique";

			result = StringAlgorithms.HasUniqueChars(input);

			Assert.AreEqual(false, result);

			input = "Unique";

			result = StringAlgorithms.HasUniqueChars(input);

			Assert.AreEqual(true, result);


			input = "";

			result = StringAlgorithms.HasUniqueChars(input);

			Assert.AreEqual(true, result);
		}


		[TestMethod]
		public void TestIsAnagramSucceeds()
		{
			string s1 = "silent";
			string s2 = "listen";

			bool isAnagram = StringAlgorithms.IsAnagram(s1, s2);

			Assert.IsTrue(isAnagram);
		}

		[TestMethod]
		public void TestIsAnagramSucceedsMultipleWords()
		{
			string s1 = "a silent yes";
			string s2 = "yes listen a";

			bool isAnagram = StringAlgorithms.IsAnagram(s1, s2);

			Assert.IsTrue(isAnagram);
		}

		[TestMethod]
		public void TestIsAnagramFails()
		{
			string s1 = "anagram not";
			string s2 = "anagram bad";

			bool isAnagram = StringAlgorithms.IsAnagram(s1, s2);

			Assert.IsFalse(isAnagram);
		}
	}
}
