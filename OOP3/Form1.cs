using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Osoba clovek;
        private void button1_Click(object sender, EventArgs e)
        {
            clovek = new Osoba(textBox1.Text, textBox2.Text, (double)numericUpDown1.Value, (double)numericUpDown2.Value);
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clovek = new Pacient(textBox1.Text, textBox2.Text, (double)numericUpDown1.Value, (double)numericUpDown2.Value, (double)numericUpDown3.Value);
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(clovek.ToString());
        }
    }
}
