using System.ComponentModel.DataAnnotations;

namespace Aisd_tree;

public class Tree
{
    public TreeNode root;

    public void AddNode(int value)
    {
        var curNode = root;
        var node = new TreeNode(value, null, null);
        if (curNode == null)
        {
            root = node;
            return;
        }

        while (curNode != null)
        {
            if (curNode.data < value)
            {
                if (curNode.right != null) curNode = curNode.right;
                else curNode.right = node;
            }

            else if (curNode.data > value)
            {
                if (curNode.left != null) curNode = curNode.left;
                else curNode.left = node;
            }
            else break;
        }
    }

    public void RemoveWithoutChildren(int value)
    {
        TreeNode curNode = root;
        TreeNode parent = null;
        if (curNode == null) throw new Exception("empty tree");
        while (curNode != null)
        {
            if (curNode.data == value)
            {
                if (parent == null)
                {
                    root = null;
                }

                else if (parent.left == curNode)
                {
                    parent.left = null;
                }
                else
                {
                    parent.right = null;
                }

                break;
            }

            parent = curNode;
            if (curNode.data > value) curNode = curNode.left;
            else curNode = curNode.right;
        }

    }

    public void RemoveWithOneChild(int value)
    {
        TreeNode curNode = root;
        TreeNode parent = null;
        if (curNode == null) throw new Exception("empty tree");
        while (curNode != null)
        {
            if (curNode.data == value)
            {
                if (parent == null)
                {
                    root = null;
                }

                else if (parent.left == curNode)
                {
                    parent.left = findChild(parent.left);
                }
                else
                {
                    parent.right = findChild(parent.right);
                }

                break;
            }

            parent = curNode;
            if (curNode.data > value) curNode = curNode.left;
            else curNode = curNode.right;
        }

        TreeNode findChild(TreeNode node)
        {
            if (node.left == null) return node.right;
            else return node.left;
        }
    }

    private int FindMinNode(TreeNode start)
    {
        var min = int.MaxValue;
        var curNode = start;
        while (curNode.left != null)
        {
            min = curNode.data;
            curNode = curNode.left;
        }

        curNode = null;
        
        return min;
    }
    public void RemoveWithTwoChildren(int value)
    {
        TreeNode curNode = root;
        TreeNode parent = null;
        if (curNode == null) throw new Exception("empty tree");
        while (curNode != null)
        {
            if (curNode.data == value)
            {
                if (parent == null)
                {
                    root = null;
                }

                else if (parent.left == curNode)
                {
                    parent.left.data = FindMinNode(parent.left);🙂
                }
                else
                {
                    parent.right.data = FindMinNode(parent.right);
                }

                break;
            }

            parent = curNode;
            if (curNode.data > value) curNode = curNode.left;
            else curNode = curNode.right;
        }
    }
    
}

public class TreeNode
{
    public int data;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int data, TreeNode left, TreeNode right)
    {
        this.data = data;
        this.left = left;
        this.right = right;
    }
}
