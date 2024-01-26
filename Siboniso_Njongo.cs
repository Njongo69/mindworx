//https://github.com/Njongo69/mindworx.git


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjongoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
            
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
