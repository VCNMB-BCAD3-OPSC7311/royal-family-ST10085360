class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode()
    {
        Children = new List<TreeNode<T>>();
    }
}