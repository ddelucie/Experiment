using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
    [TestClass]
	public class BaseClassTests
    {
		
	    [TestMethod]
		public void BaseAbstractTest()
	    {
		    var baseAbstractImpl = new BaseAbstractImpl();
			baseAbstractImpl.PrintVars();
			baseAbstractImpl.PrintVarsAbstract();
			baseAbstractImpl.PrintVarsVirtual();
		    baseAbstractImpl.V = 222;
			baseAbstractImpl.PrintV();
			baseAbstractImpl.U = 333;
			baseAbstractImpl.PrintU();
	    }

    }
}
