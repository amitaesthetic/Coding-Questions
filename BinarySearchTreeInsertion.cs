using System;
using Newtonsoft.Json;

public class Node
{
    public Node? left;
    public Node? right;
    public int value;
    public Node(int Value)
    {
        this.value = Value;
        right = null;
        left = null;
    }
}

class BinarySearchTree
{
    public Node root;
    public BinarySearchTree()
    {
        this.root = null;
    }

    public void insert(int value)
    {
        Node NewNode = new Node(value);
        if(this.root==null)
        {
            this.root = NewNode;
        }
        else
        {
            var CurrentNode = this.root;
            while(true)
            {
                if(value < CurrentNode.value)
                {
                    //Left
                    if (CurrentNode.left == null)
                    {
                        CurrentNode.left = NewNode;
                        break;
                    }
                    CurrentNode = CurrentNode.left;
                }
                else
                {
                    //right
                    if (CurrentNode.right == null)
                    {
                        CurrentNode.right = NewNode;
                        break;
                    }
                    CurrentNode = CurrentNode.right;
                }
            }
        }
    }
}

class Solution
{
    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.insert(9);
        tree.insert(4);
        tree.insert(6);
        tree.insert(20);
        tree.insert(170);
        tree.insert(15);
        tree.insert(1);

        string treeJSON = JsonConvert.SerializeObject(tree.root);
        Console.WriteLine(treeJSON);
        Console.ReadLine();
        //Console.Close();
    }
}
