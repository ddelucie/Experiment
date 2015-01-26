using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.DataStructures
{
	public class TreeNode<T>
	{
		public TreeNode<T> Right { get; set; }
		public TreeNode<T> Left { get; set; }
		public T Value { get; set; }

	}
    public class BinaryTree<T>
    {
       

        public TreeNode<T> Root { get; set; }

        /*
         * visit left
         * if null visit right 
         *      if null go back up to parent and visit right
         * CALL
         *      
         *      
         */
        public void PreorderTraversal(TreeNode<T> node)
        {
	        if (node == null) return;

			Console.WriteLine(node.Value);

			PreorderTraversal(node.Left);
			PreorderTraversal(node.Right);
        }

	    public void InOrderTraversal(TreeNode<T> node)
	    {
		    if (node == null) return;
		    InOrderTraversal(node.Left);
			Console.WriteLine(node.Value);
		    InOrderTraversal(node.Right);
	    }

		public void PostOrderTraversal(TreeNode<T> node)
		{
			if (node == null) return;
			PostOrderTraversal(node.Left);
			PostOrderTraversal(node.Right);
			Console.WriteLine(node.Value);
		}

    }
}
