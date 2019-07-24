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
    public partial class Izbor : Form
    {
        public Izbor()
        {
           
            InitializeComponent();
           
        }
        
                private void button1_Click(object sender, EventArgs e)
        {
            Prodavnica Prodavnica = new Prodavnica();
            Prodavnica.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usluge Usluge = new Usluge();
            Usluge.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Početna Početna = new Početna();
            Početna.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
