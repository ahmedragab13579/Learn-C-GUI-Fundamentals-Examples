using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class Image_List : Form
    {
        public Image_List()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }
        private void CheckallNodes(TreeNode node,bool ischecked)
        {
            foreach(TreeNode N in node.Nodes)
            {
                N.Checked = ischecked;
                if(N.Nodes.Count>0)
                {
                    CheckallNodes(N, ischecked);
                }

            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {

            CheckallNodes(e.Node,e.Node.Checked);
        }

      
    }
}
