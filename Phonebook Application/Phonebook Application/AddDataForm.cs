using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Phonebook_Application
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void AddDataForm_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnSave.Enabled = true;
            btnNewData.Enabled = false;
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fn = AppDomain.CurrentDomain.BaseDirectory;
            string path = fn + "ID_" + this.textBox1.Text + ".txt";
            File.WriteAllText(path,textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\t" + textBox5.Text);
            MessageBox.Show("Contact Added Successfully.", "Phonebook", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            btnNewData.Enabled = true;
            panel1.Enabled = false;

        }
    }
}
