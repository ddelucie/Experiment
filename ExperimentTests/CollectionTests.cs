using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
	[TestClass]
	class CollectionTests
	{

		class Band 
		{public string Name { get; set; }}

		[TestMethod]
		public void CollectionTest()
		{
			Band[] objects = {new Band {Name = "Iron Maiden"}};
			objects = new Band[2];
			objects[0] = null;
			objects[1] = new Band { Name = "Iron Maiden" };
			var first = objects.FirstOrDefault(); // returns "Iron Maiden"
			Console.WriteLine(first == null ? "NULL" : first.Name);

			first = objects.FirstOrDefault(o => o.Name == "Slayer"); // returns null
			Console.WriteLine(first == null ? "NULL" : first.Name);

			objects = new Band[] {};
			first = objects.FirstOrDefault(); // returns null
			//first = objects.First(); // returns InvalidOperationException

			Console.WriteLine(first == null ? "NULL" : first.Name);

			first = objects.DefaultIfEmpty(new Band { Name = "Black Sabbath" }).FirstOrDefault();  // returns "Black Sabbath"
			Console.WriteLine(first == null ? "NULL" : first.Name); 
			first = objects.DefaultIfEmpty(new Band { Name = "Black Sabbath" }).First();  // returns "Black Sabbath"
			Console.WriteLine(first == null ? "NULL" : first.Name);

			objects = new Band[] { new Band { Name = "Iron Maiden" } };
			first = objects.DefaultIfEmpty(new Band { Name = "Black Sabbath" }).FirstOrDefault(o => o.Name == "Slayer");  // returns null
			Console.WriteLine(first == null ? "NULL" : first.Name);

			first = objects.FirstOrDefault(o => o.Name == "Slayer") ?? new Band { Name = "Black Sabbath" };  // returns "Black Sabbath" 
			Console.WriteLine(first == null ? "NULL" : first.Name);

			objects = new Band[] { new Band { Name = "Iron Maiden" } };
			first = objects.Where(o => o.Name == "Slayer")
				.DefaultIfEmpty(new Band { Name = "Black Sabbath" })
				.FirstOrDefault();   // returns "Black Sabbath" 
			Console.WriteLine(first == null ? "NULL" : first.Name);

			objects = new Band[2] ;
			objects[0] = null;
			objects[1] = new Band {Name = "Iron Maiden"};
			first = objects.Where(o => o.Name == "Slayer")
				.DefaultIfEmpty(new Band { Name = "Black Sabbath" })
				.FirstOrDefault();   // returns "Black Sabbath" 
			Console.WriteLine(first == null ? "NULL" : first.Name);
		}
	}
}
