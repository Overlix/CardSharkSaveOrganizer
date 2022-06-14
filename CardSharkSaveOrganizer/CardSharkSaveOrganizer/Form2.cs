using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CardSharkSaveOrganizer
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public string NewName;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                NewName = textBox1.Text;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
