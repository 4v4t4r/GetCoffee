using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count > 0)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, ListBox1.Items.Count);
                ListBox1.Select();
                ListBox1.SelectedItem = ListBox1.Items[randomNumber];
                label2.Text = "Winner = " + ListBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Enter names!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // Visit website
            System.Diagnostics.Process.Start("http://www.bdekker.nl");
        }
    }
}
