using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kasuka
{
    public partial class Form1 : Form
    {
        string pictureFileForSelection = "";
        string lang1TextForSelection = "";
        string lang2TextForSelection = "";
        string lang1SoundFileForSelection = "";
        string lang2SoundFileForSelection = "";

        Timer timer = new Timer();

        public static void CenterHorizontally(Control control)
        {
            Rectangle parentRect = control.Parent.ClientRectangle;
            control.Left = (parentRect.Width - control.Width) / 2;
        }

        private string getNodeStringRecursively(TreeNode treeNode, string name, string searchFormat)
        {
            if (treeNode.Name == name)
            {
                if ((searchFormat == "picture") || (searchFormat == "lang1Sound") || (searchFormat == "lang2Sound"))
                { return (treeNode.Text); }
                else if (searchFormat == "lang2Text")
                { return (treeNode.ToolTipText); }
                else { return ("Error!! Wrong Searh Format!!"); }
            }
            else
            {
                TreeNodeCollection nodes = treeNode.Nodes;
                foreach (TreeNode tn in nodes)
                {
                    string result = "";
                    result = getNodeStringRecursively(tn, name, searchFormat);
                    if (result != "")
                    {
                        return result;
                    }
                }
                return ("");
            }
        }

        private TreeNode getNodeRecursively(TreeNode treeNode, string name)
        {
            if (treeNode.Name == name)
            {
                return (treeNode);
            }
            else
            {
                TreeNodeCollection nodes = treeNode.Nodes;
                foreach (TreeNode tn in nodes)
                {
                    TreeNode result = null;
                    result = getNodeRecursively(tn, name);
                    if (result != null)
                    {
                        return result;
                    }
                }
                return (null);
            }
        }


        private void playSoundForPicEventHandler(Object myObject, EventArgs myEventArgs)
        {

            SoundPlayer player = new SoundPlayer(@lang1SoundFileForSelection);
            player.PlaySync();

            player = new SoundPlayer(@lang2SoundFileForSelection);
            player.PlaySync();

            itonTextLabel.Text = lang2TextForSelection;

            CenterHorizontally(itonTextLabel);

            CenterHorizontally(pictureBox1);
            pictureBox1.ImageLocation = @pictureFileForSelection;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox1.Load();


            englishTextLabel.Text = lang1TextForSelection;
            CenterHorizontally(englishTextLabel);
        }

        public Form1()
        {
            InitializeComponent();
            CenterHorizontally(englishTextTreeForIton);
            CenterHorizontally(pictureBox1);
            CenterHorizontally(englishTextLabel);
            CenterHorizontally(itonTextLabel);
            timer.Tick += new EventHandler(playSoundForPicEventHandler);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void englishTreeWithoutPics_AfterSelect(object sender, TreeViewEventArgs e)
        {
            timer.Stop();
            String name = englishTextTreeForIton.SelectedNode.Name;
            string picFileSearched = "";
            string lang2TextSearched = "";
            string lang1SoundSearched = "";
            string lang2SoundSearched = "";

            TreeNodeCollection picsNodes = picsTreeForIton.Nodes;
            TreeNodeCollection lang2SoundsNodes = ItonSoundsTreeForIton.Nodes;
            TreeNodeCollection lang1SoundsNodes = EnglishSoundsTreeForIton.Nodes;

            foreach (TreeNode n in picsNodes)
            {
                picFileSearched = getNodeStringRecursively(n, name, "picture");
                if (picFileSearched != "") { break; }
            }
            if (picFileSearched != "")
            {
                pictureFileForSelection = picFileSearched;
            }
            if (picFileSearched == "")
            {
                pictureFileForSelection = "Sorry! Still Struggling with picture file";
            }

            foreach (TreeNode n in lang2SoundsNodes)
            {
                lang2TextSearched = getNodeStringRecursively(n, name, "lang2Text");
                lang2SoundSearched = getNodeStringRecursively(n, name, "lang2Sound");
                if ((lang2TextSearched != "") && (lang2SoundSearched != "")) { break; }
            }
            if ((lang2TextSearched != "") && (lang2SoundSearched != ""))
            {
                lang2TextForSelection = lang2TextSearched;
                lang2SoundFileForSelection = lang2SoundSearched;
            }
            if ((lang2TextSearched == "") || (lang2SoundSearched == ""))
            {
                lang2TextForSelection = "Sorry! Still Struggling with text or sound of second language";
                lang2SoundFileForSelection = "Sorry! Still Struggling with text or sound of second language";
            }

            foreach (TreeNode n in lang1SoundsNodes)
            {
                lang1SoundSearched = getNodeStringRecursively(n, name, "lang1Sound");
                if (lang1SoundSearched != "") { break; }
            }
            if (lang1SoundSearched != "")
            {
                lang1SoundFileForSelection = lang1SoundSearched;
            }
            if (lang1SoundSearched == "")
            {
                lang1SoundFileForSelection = "Sorry! Still Struggling with sound of first language";
            }

            lang1TextForSelection = englishTextTreeForIton.SelectedNode.Text;
            timer.Start();
        }

        private void englishTextTreeForIton_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clonedNode = new TreeNode();

            clonedNode = (TreeNode)englishTextTreeForIton.SelectedNode.Clone();
            englishTextTreeForIton.Nodes.Insert(0, clonedNode);
            englishTextTreeForIton.Nodes.RemoveAt(1);
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = englishTextTreeForIton.SelectedNode.Name;
            TreeNodeCollection fixedTvNodes = fixedTreeView.Nodes;
            TreeNode nodeSearched = null;

            foreach (TreeNode n in fixedTvNodes)
            {
                nodeSearched = getNodeRecursively(n, name);
                if (nodeSearched != null) { break; }
            }
            if (nodeSearched != null)
            {
                if (nodeSearched.Parent != null)
                {
                    englishTextTreeForIton.TopNode = nodeSearched.Parent;

                    TreeNode clonedNode = new TreeNode();

                    clonedNode = (TreeNode)((nodeSearched.Parent).Clone());
                    englishTextTreeForIton.Nodes.Insert(0, clonedNode);
                    englishTextTreeForIton.Nodes.RemoveAt(1);
                }
            }
        }
        private void fixedTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void picsTreeForIton_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ZuluBodyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            this.Hide();

            previousForm.Show();
        }
    }
}
