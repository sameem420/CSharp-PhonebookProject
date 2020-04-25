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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an ID to search.", "PhoneBook Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var keyword = textBox1.Text.ToString();
                string fn = AppDomain.CurrentDomain.BaseDirectory;
                string path = fn + @"phonebook_data.txt";
                string[] lines = File.ReadAllLines(path);
                string[] chars = new string[5];
                bool found = false;
                foreach (var line in lines)
                {
                    if (line.StartsWith(keyword))
                    {
                        string newLine = line.Replace("\r\n", "");
                        newLine = newLine.Replace("\n", "");
                        chars = newLine.Split('\t');
                        found = true;
                        break;
                    }

                }
                if (found)
                {
                    textBox2.Text = chars[1].ToString();
                    textBox3.Text = chars[2].ToString();
                    textBox4.Text = chars[3].ToString();
                    textBox5.Text = chars[4].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found.", "PhoneBook Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                groupBox2.Enabled = true;
            }
        }
    }
}
