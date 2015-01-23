using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public class BaseClass
	{
		private string s1 = "BASE";

		public BaseClass(string s){}
		public BaseClass() { }
		public virtual string Name()
		{
			return s1;
		}
	}

	public class InheritedClass : BaseClass
	{
		private string s1 = "INHERIT";
		public InheritedClass() { }
		public InheritedClass(string s) { }

		public override string Name()
		{
			return s1;
		}
	}


	public abstract class BaseAbstract
	{
		private int priv = 1;
		public int pub = 2;

		public virtual int V { get; set; }
		public int U { get; set; }
		public void PrintVars()
		{
			Console.WriteLine(priv);
			Console.WriteLine(pub);
		}
		public virtual void PrintVarsVirtual()
		{
			Console.WriteLine(priv);
			Console.WriteLine(pub);
		}

		public abstract void PrintVarsAbstract();
		public abstract void PrintV();
	}

	public class BaseAbstractImpl : BaseAbstract
	{
		public override int V { get; set; }
		public new int U { get; set; }

		public override void PrintVarsAbstract()
		{
			{
				Console.WriteLine("BaseAbstractImpl");
			}
		}

		public override void PrintV()
		{
			{
				
				Console.WriteLine(V);
			}
		}


		public void PrintU()
		{
			{

				Console.WriteLine(U);
			}
		}
	}
}
