namespace Exemple.Genercs
{
    public class BinarySerachTeary<T>
    {
        private TreeNode<T> root;

        public BinarySerachTeary()
        {
            root = null;
        }

        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        private TreeNode<T> Insert(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
            }
            else
            {
                if (Comparer<T>.Default.Compare(value, node.Value) < 0)
                {
                    node.Left = Insert(node.Left, value);
                }
                else
                {
                    node.Right = Insert(node.Right, value);
                }
            }

            return node;
        }

        public bool Search(T value)
        {
            return Search(root, value);
        }

        private bool Search(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return false;
            }

            if (Comparer<T>.Default.Compare(value, node.Value) == 0)
            {
                return true;
            }

            if (Comparer<T>.Default.Compare(value, node.Value) < 0)
            {
                return Search(node.Left, value);
            }

            return Search(node.Right, value);
        }

        public void Display()
        {
            Display(root);
        }

        private void Display(TreeNode<T> node)
        {
            if (node != null)
            {
                Display(node.Left);
                System.Console.WriteLine(node.Value);
                Display(node.Right);
            }
        }
    }

    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
