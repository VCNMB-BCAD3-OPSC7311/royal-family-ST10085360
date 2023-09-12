using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;

namespace FamilyTree
{
    public partial class Form1 : Form
    {
        private Tree<String> familyTree;
        private BindingList<TreeNode<String>> familyMemberList = new BindingList<TreeNode<String>>();


        public Form1()
        {
            InitializeComponent();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFamilyMember();
        }

        private void AddFamilyMember()
        {
            string memberName = txtName.Text;
            TreeNode<String> selectedParent = cmbPred.SelectedItem as TreeNode<String>;

            if (string.IsNullOrWhiteSpace(memberName))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            TreeNode<String> newMember = new TreeNode<String>() { Data = memberName };

            if (selectedParent == null)
            {

                familyTree.Root.Children.Add(newMember);
            }
            else
            {

                newMember.Parent = selectedParent;
                selectedParent.Children.Add(newMember);
            }

            PopulateTreeView(familyTree.Root, null);


            cmbPred.DataSource = familyMemberList;
            cmbPred.DisplayMember = "Data";
            cmbPred.ValueMember = "Data";
            familyMemberList.Add(newMember);


            txtName.Clear();
        }

        private void PopulateTreeView(TreeNode<String> node, TreeNode parentNode)
        {
            TreeNode treeNode = new TreeNode(node.Data.ToString());

            if (parentNode == null)
            {
                TreeView.Nodes.Clear();
                TreeView.Nodes.Add(treeNode);
            }
            else
            {
                parentNode.Nodes.Add(treeNode);
            }

            foreach (var child in node.Children)
            {
                PopulateTreeView(child, treeNode);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (familyTree == null)
            {
                TreeNode<String> monarch = new TreeNode<String>() { Data = "King George VI" };

                familyTree = new Tree<String>();
                familyTree.Root = monarch;

                // Add the monarch to the TreeView.
                TreeNode treeNode = new TreeNode(monarch.Data.ToString());
                TreeView.Nodes.Add(treeNode);

                familyMemberList.Add(monarch);
            }
            cmbPred.DataSource = familyMemberList;
            cmbPred.DisplayMember = "Data";
            cmbPred.ValueMember = "Data";


        }

        private TreeNode<String> FindAndHighlightMember(TreeNode<String> node, string nameToFind, ref TreeNode<String> parent)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data.ToString() == nameToFind)
            {
                TreeNode[] foundNodes = TreeView.Nodes.Find(node.Data.ToString(), true);

                if (foundNodes.Length > 0)
                {
                    TreeNode treeNode = foundNodes[0];
                    treeNode.Expand(); // Expand the node.
                    TreeView.SelectedNode = treeNode;
                }

                parent = node.Parent;
                return node;
            }

            // Search in the children recursively.
            foreach (var child in node.Children)
            {
                TreeNode<String> result = FindAndHighlightMember(child, nameToFind, ref parent);
                if (result != null)
                {
                    // If the member is found in the child's subtree, return it.
                    return result;
                }
            }

            return null;
        }

        private void SearchForMemberAndHighlight(string nameToFind)
        {
            // Start the search from the root of the tree.
            TreeNode<String> parent = null; // Initialize the parent as null.
            TreeNode<String> foundNode = FindAndHighlightMember(familyTree.Root, nameToFind, ref parent);

            if (foundNode != null)
            {
                // Display a message with the found member's name and its parent's name (predecessor).
                string message = $"Member \"{nameToFind}\" was found. Predecessor is \"{parent?.Data}\".";
                MessageBox.Show(message);
            }
            else
            {
                // Display a message if the member was not found.
                MessageBox.Show($"Member \"{nameToFind}\" was not found.");
            }
        }

        // Example usage:
        

        private void button1_Click(object sender, EventArgs e)
        {
            string nameToFind = txtSearch.Text;
            SearchForMemberAndHighlight(nameToFind);
        }
    }
}