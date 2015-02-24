using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment;
using Experiment.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExperimentTests
{
	[TestClass]
	public class MyLinkedListTests
	{
		[TestMethod]
		public void TestMyLinkedList_InsertAfter()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };

			WriteLinkedList(linkedList);

			MyLinkedList.Node newNode = new MyLinkedList.Node() { Data = new { Name = "NEW" } };
			linkedList.InsertAfter(root, newNode);

			WriteLinkedList(linkedList);

			MyLinkedList.Node newNode2 = new MyLinkedList.Node() { Data = new { Name = "NEW2" } };
			linkedList.InsertAfter(linkedList.GetLast(root), newNode2);

			WriteLinkedList(linkedList);

			MyLinkedList.Node newNode3 = new MyLinkedList.Node() { Data = new { Name = "NEW3" } };
			linkedList.InsertAfter(newNode, newNode3);

			WriteLinkedList(linkedList);

		}

		[TestMethod]
		public void TestMyLinkedList_Add()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };

			WriteLinkedList(linkedList);

			MyLinkedList.Node newRoot = new MyLinkedList.Node() { Data = new { Name = "NEWRoot" } };
			linkedList.AddToStart(newRoot);

			WriteLinkedList(linkedList);


		}
		[TestMethod]
		public void TestMyLinkedList_MoveN()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };

			int n = 2;
			MyLinkedList.Node resultNode = linkedList.MoveN(root, n);
			Assert.AreEqual(n.ToString(), resultNode.Data.Name);

			n = 100;
			resultNode = linkedList.MoveN(root, n);
			Assert.AreEqual(null, resultNode);

		}



		[TestMethod]
		public void TestMyLinkedList_NthToLast()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };

			int n = 2;
			MyLinkedList.Node resultNode = linkedList.NthToLast(n);
			Assert.AreEqual(2.ToString(), resultNode.Data.Name);

			n = 1;
			resultNode = linkedList.NthToLast(n);
			Assert.AreEqual(3.ToString(), resultNode.Data.Name);

			n = 3;
			resultNode = linkedList.NthToLast(n);
			Assert.AreEqual("1", resultNode.Data.Name);

			n = 4;
			resultNode = linkedList.NthToLast(n);
			Assert.AreEqual("ROOT", resultNode.Data.Name);

			n = 10;
			resultNode = linkedList.NthToLast(n);
			Assert.AreEqual(null, resultNode);

		}

		
		[TestMethod]
		public void TestMyLinkedList_Reverse()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };
			WriteLinkedList(linkedList);


			linkedList.Reverse();

			WriteLinkedList(linkedList);
		}

		[TestMethod]
		public void TestMyLinkedList_RecursiveReverse()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			linkedList.Root = root;
			root.Next = new MyLinkedList.Node() { Data = new { Name = "1" } };
			root.Next.Next = new MyLinkedList.Node() { Data = new { Name = "2" } };
			root.Next.Next.Next = new MyLinkedList.Node() { Data = new { Name = "3" } };
			WriteLinkedList(linkedList);


			linkedList.RecursiveReverse(linkedList.Root);

			WriteLinkedList(linkedList);
		}

		[TestMethod]
		public void TestMyLinkedList_CompareReverse()
		{
			MyLinkedList linkedList = new MyLinkedList();
			MyLinkedList.Node root = new MyLinkedList.Node() { Data = new { Name = "ROOT" } };
			MyLinkedList.Node node = root;
			for (int i = 0; i < 10000; i++)
			{
				node.Next = new MyLinkedList.Node() { Data = new { Name = i } };
				node = node.Next;
			}
			linkedList.Root = root;

			System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start(); 
			linkedList.RecursiveReverse(linkedList.Root); 
			
			Console.WriteLine(stopwatch.ElapsedMilliseconds);
			stopwatch.Restart();
			linkedList.Reverse(); 
			Console.WriteLine(stopwatch.ElapsedMilliseconds);
		}

		private static void WriteLinkedList(MyLinkedList linkedList)
		{
			Console.WriteLine("--START--");
			MyLinkedList.Node loopNode = linkedList.Root;
			Console.WriteLine(loopNode.Data.Name);
			while (loopNode.Next != null)
			{
				loopNode = loopNode.Next;
				Console.WriteLine(loopNode.Data.Name);
			}

			Console.WriteLine("--END--");
		}
	}
}
