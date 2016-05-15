using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{


	public class VarExperiments
	{

		public void DoThings()
		{
			BaseClass myBase1 = new InheritedClass();
			string name = myBase1.Name();
			var myBase2 = new InheritedClass();
			name = myBase2.Name();

			var customers = new List<BaseAbstractImpl>();
			var distributors = new List<BaseAbstractImpl>();

			var innerJoinQuery =
				from cust in customers
				join dist in distributors on cust.U equals dist.U
				select new { CustomerName = cust.V, DistributorName = dist.V };


		}
	}
}
