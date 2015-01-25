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
	}
}
