using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phonebook_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddRecordForm adform = new AddRecordForm();
            adform.MdiParent = this;
            adform.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchForm sform = new SearchForm();
            sform.MdiParent = this;
            sform.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton6_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton7_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton8_Click(sender, e);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ViewRecordForm vform = new ViewRecordForm();
            vform.MdiParent = this;
            vform.Show();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            UpdateForm uform = new UpdateForm();
            uform.MdiParent = this;
            uform.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DeleteRecordForm dform = new DeleteRecordForm();
            dform.MdiParent = this;
            dform.Show();
        }
    }
}
