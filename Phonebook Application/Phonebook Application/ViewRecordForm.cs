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
    public partial class ViewRecordForm : Form
    {
        public ViewRecordForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Phone Number", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Comment", typeof(string));
            dataGridView1.DataSource = dt;
            string fn = AppDomain.CurrentDomain.BaseDirectory;
            string path = fn + @"phonebook_data.txt";
            string[] lines = File.ReadAllLines(path);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('\t');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dt.Rows.Add(row);
            }
        }
    }
}
