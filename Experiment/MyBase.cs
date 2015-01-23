using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	class MyBase
	{
		protected int p;
		internal int i;
		private int pri;

		public virtual void Set()
		{
			p = 1;
			i = 2;
			pri = 3;
		}
	}

	class MyDerived : MyBase
	{
		public override void Set()
		{
			p = 100;
			i = 200;
			//pri = 300;
		}
	}
}
