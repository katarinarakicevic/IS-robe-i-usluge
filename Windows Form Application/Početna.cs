using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Početna : Form

    {
        
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Seminarski Informacioni sistemi\korisnici.accdb");
        public Početna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from korisnici where korisnik = '" + textBox1.Text + "' and lozinka = '" + textBox2.Text + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                // count++;
                //
            }

            {
                if (count == 1)
                {
                    MessageBox.Show("Korisničko ime i lozinka su ispravni");
                    Izbor Izbor = new Izbor();
                    Izbor.Show();
                    this.Hide();
                }


                 
                else if(count > 1)
                {
                    MessageBox.Show("Korisničko ime i lozinka već postoje");
                }




                else
                {
                    MessageBox.Show("Korisničko ime i lozinka su neispravni");
                }

                conn.Close();


            }
        }
  
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Početna_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
    