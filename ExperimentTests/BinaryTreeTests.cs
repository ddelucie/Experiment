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
    public class BinaryTreeTests
    {
		BinaryTree<int> tree = new BinaryTree<int>();
 		TreeNode<int>  root = new TreeNode<int>(){Value = 1};
		TreeNode<int> left1 = new TreeNode<int>() { Value = 2};
		TreeNode<int> right1 = new TreeNode<int>() { Value = 3 };
		TreeNode<int> left2 = new TreeNode<int>() { Value = 4 };
		TreeNode<int> right2 = new TreeNode<int>() { Value = 5 };
		TreeNode<int> left3 = new TreeNode<int>() { Value = 6 };
		TreeNode<int> right3 = new TreeNode<int>() { Value = 7 };

	    [TestMethod]
	    public void PreorderTraversalTest()
	    {
		    root.Left = left1;
		    root.Right = right1;
		    left1.Left = left2;
		    left1.Right = right2;
		    right1.Left = left3;
		    left2.Right = right3;
			tree.PreorderTraversal(root);


	    }

		[TestMethod]
		public void InOrderTraversalTest()
		{
			root.Left = left1;
			root.Right = right1;
			left1.Left = left2;
			left1.Right = right2;
			right1.Left = left3;
			left2.Right = right3;
			tree.InOrderTraversal(root);
		}

		[TestMethod]
		public void PostOrderTraversalTest()
		{
			root.Left = left1;
			root.Right = right1;
			left1.Left = left2;
			left1.Right = right2;
			right1.Left = left3;
			left2.Right = right3;
			tree.PostOrderTraversal(root);


		}
    }
}
