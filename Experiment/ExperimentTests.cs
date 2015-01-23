using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Experiment
{
	[TestClass]
	public class ExperimentTests
	{
		[TestMethod]
		public void Test()
		{
			string answer = BinaryConverter.Convert(1);
			Console.WriteLine(answer);
		}
	}
}
