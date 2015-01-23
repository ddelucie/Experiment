using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public class DynamicExperiments
	{
		public void Declaring()
		{
			var v = "string";
			v = v.ToUpper();

			//object o = "string";
			//o = o.ToUpper();


			dynamic d = "string";
			d = d.ToUpper();
		}
	}
}
