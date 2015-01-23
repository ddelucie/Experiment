using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public class CollectionPlayground
	{
		public static ISet<int> SetMerge()
		{
			//IList<int> list = new List<int>();
			//int i = list.ElementAt(1);

			ISet<int> set = new HashSet<int>();
			set.Add(1);
			set.SymmetricExceptWith(new List<int>() {1, 2, 3, 4});
			return set;
		}

		public static IReadOnlyList<string> ReadOnlyListCreate()
		{
			IReadOnlyList<string> strings = new List<string>() {"dan", "dave", "john", "bruce"};
			IList<string> mutable = strings.ToList();
			mutable.Remove("dan");
			return mutable as IReadOnlyList<string>;
		}


	}
}
