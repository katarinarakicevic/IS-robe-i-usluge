using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Račun : Form
    {
        public Račun()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c= textBox3.Text;
            string d = textBox4.Text;
            if (MessageBox.Show("Narudžbenica pripremljena...", "PORUKA O PRIPREMI NARUDŽBENICE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) { }
            Narudžbenica Narudžbenica = new Narudžbenica();
            Narudžbenica.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(textBox4.Text);
            listView1.Items.Add(lvi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prodavnica Prodavnica = new Prodavnica();
            Prodavnica.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
