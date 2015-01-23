using System;
using System.Collections.Generic;
using Experiment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
	[TestClass]
	public class MultipleInterfaceTests
	{

		[TestMethod]
		public void Test1()
		{
			LesPaul lesPaul = new LesPaul();
			Console.WriteLine(lesPaul.PlaySolo("Playing a solo"));
			//Console.WriteLine(lesPaul.PlayRhythm("Playing rhythm"));


			Strat strat = new Strat();
			Console.WriteLine(((IGuitar) strat).PlaySolo("Playing my solo"));
			Console.WriteLine(((IAxe)strat).PlaySolo("Playing my solo"));
		}

	





	}
}
