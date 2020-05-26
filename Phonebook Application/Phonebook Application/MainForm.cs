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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AboutMe abt = new AboutMe();
            abt.MdiParent = this;
            abt.Show();
        }

        public void combox_load_background()
        {
            for(int i =1; i<4;i++)
            {
                this.comboBox1.Items.Add("Image " + i.ToString());
            }
        }

        public void background_image_loader(Int32 combo_index)
        {
            string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\images\\" + combo_index.ToString() + ".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Int32 si;
            si = Properties.Settings.Default.selected_back_image_index;
            background_image_loader(si);
            //-------------------------------------------------------------
            combox_load_background();
            this.comboBox1.SelectedIndex = si;
        }

        public void getTime()
        {
            this.lbl_showTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 si;
            si = this.comboBox1.SelectedIndex;
            background_image_loader(si);
            //----------- save the selected image index ------------------
            Properties.Settings.Default.selected_back_image_index = this.comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }
}
