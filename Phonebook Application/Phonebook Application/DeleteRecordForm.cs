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
    public partial class DeleteRecordForm : Form
    {
        public DeleteRecordForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an ID to delete the record.", "PhoneBook Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var keyword = textBox1.Text.ToString();
                string fn = AppDomain.CurrentDomain.BaseDirectory;
                string path = fn + @"phonebook_data.txt";
                var logFile = File.ReadAllLines(path);
                var logList = new List<string>(logFile);
                string[] chars = new string[5];
                for (int i = logList.Count - 1; i >= 0; i--)
                {
                    if (logList[i].StartsWith(keyword))
                    {
                        logList.RemoveAt(i);
                    }  
                    MessageBox.Show("Contact Deleted Sucessfully.", "PhoneBook Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                File.WriteAllLines(path, logList.ToArray());
            }
        }
    }
}
