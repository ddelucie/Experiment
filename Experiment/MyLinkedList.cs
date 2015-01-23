using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public class MyLinkedList
	{
		public class Node
		{
			public Node Next { get; set; }
			public dynamic Data { get; set; }
		}

		public Node Root { get; set; }

		public Node GetLast(Node current)
		{
			if (current == null) return null;
			Node loopNode = current;
			while (loopNode.Next != null)
			{
				loopNode = loopNode.Next;
			}
			return loopNode;
		}

		public Node MoveN(Node current, int n)
		{
			if (current == null) return null;
			Node loopNode = current;
			int count = 0;
			while (true)
			{
				if (loopNode == null) return null;
				if (count >= n) break;
				loopNode = loopNode.Next;
				count++;
			}
			return loopNode;
		}


		public void InsertAfter(Node currNode, Node newNode)
		{
			if (currNode == null) return;
			
			Node temp = currNode.Next;
			currNode.Next = newNode;
			newNode.Next = temp;
		}

		public void AddToStart(Node newNode)
		{
			newNode.Next = Root;
			this.Root = newNode;
		}

		public void RemoveFirst()
		{
			if (Root.Next != null)
				this.Root = Root.Next;
			else Root = null;
		}

		public Node NthToLast(int n)
		{
			Node nodeN2 = Root;
			Node nodeN1 = Root;

			// move NodeN1 up N-1 nodes
			nodeN1 = MoveN(nodeN1,n-1);
			if (nodeN1 == null) return null;
			while(true)
			{
				if(nodeN1.Next == null)
				{
					return nodeN2;
				}
				else
				{
					nodeN1 = nodeN1.Next;
					nodeN2 = nodeN2.Next;
				}
			}

		}

		public void Reverse()
		{
			Stack<dynamic> stack = new Stack<dynamic>();
			Node node = Root;
			while (node != null)
			{
				stack.Push(new Node(){Data =node.Data});
				node = node.Next;
			}
			this.Root = stack.Pop();
			node = Root;
			while (stack.Count > 0)
			{
				node.Next = stack.Pop();
				node = node.Next;
			}

		}

		public void RecursiveReverse(Node node)
		{
			if (node == null) return;
			if (node.Next == null)
			{
				Root = node;
				return;
			}
			RecursiveReverse(node.Next);
			node.Next.Next = node;
			node.Next = null;
		}
	}
}
