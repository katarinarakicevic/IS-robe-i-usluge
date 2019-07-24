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
    public partial class Narudžbenica : Form
    {
        public Narudžbenica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'narudženicaDataSet.Narudženica' table. You can move, or remove it, as needed.
            this.narudženicaTableAdapter.Fill(this.narudženicaDataSet.Narudženica);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Račun Račun= new Račun();
            Račun.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
    }
}
