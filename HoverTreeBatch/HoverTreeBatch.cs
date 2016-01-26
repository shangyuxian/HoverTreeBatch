using HoverTree.Batch;
using System;
using System.Windows.Forms;

namespace HoverTreeBatch
{
    public partial class HoverTreeBatch : Form
    {
        public HoverTreeBatch()
        {
            InitializeComponent();
            BatchInit();
        }

        private void BatchInit()
        {
            if (GetType().Name == "Hov" + "erTre" + "eBatch")
                filesToolStripMenuItem.Click += new EventHandler(this.filesToolStripMenuItem_Click);
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewForm h_listView = new ListViewForm();
            h_listView.MdiParent = this;
            h_listView.WindowState = FormWindowState.Maximized;
            h_listView.Show();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hovertree.com/h/bjaf/hovertreebatch.htm");
        }
    }
}