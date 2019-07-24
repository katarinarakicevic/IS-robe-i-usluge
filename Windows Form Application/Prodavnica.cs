using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Prodavnica : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Seminarski Informacioni sistemi\proizvodi.accdb");
        public Prodavnica()
        {
            InitializeComponent();
           

        }
        
            

        
        private void Prodavnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proizvodiDataSet6.KLIJENT' table. You can move, or remove it, as needed.
            this.kLIJENTTableAdapter1.Fill(this.proizvodiDataSet6.KLIJENT);
            // TODO: This line of code loads data into the 'proizvodiDataSet6.KATALOG_PROIZVODA' table. You can move, or remove it, as needed.
            this.kATALOG_PROIZVODATableAdapter1.Fill(this.proizvodiDataSet6.KATALOG_PROIZVODA);
            // TODO: This line of code loads data into the 'proizvodiDataSet6.PROIZVOD' table. You can move, or remove it, as needed.
            this.pROIZVODTableAdapter1.Fill(this.proizvodiDataSet6.PROIZVOD);
            // TODO: This line of code loads data into the 'proizvodiDataSet6.FAKTURA' table. You can move, or remove it, as needed.
            this.fAKTURATableAdapter1.Fill(this.proizvodiDataSet6.FAKTURA);
            // TODO: This line of code loads data into the 'proizvodiDataSet6.NARUDZBENICA' table. You can move, or remove it, as needed.
            this.nARUDZBENICATableAdapter1.Fill(this.proizvodiDataSet6.NARUDZBENICA);
        
           
          // TODO: This line of code loads data into the 'proizvodiDataSet6.PRODAVAC_IT_PROIZVODA' table. You can move, or remove it, as needed.
            this.pRODAVAC_IT_PROIZVODATableAdapter1.Fill(this.proizvodiDataSet6.PRODAVAC_IT_PROIZVODA);
            
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM KATALOG_PROIZVODA where KATALOG_ID= " + textBox1.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
               
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into KATALOG_PROIZVODA (KATALOG_ID,NAZIV_PROIZVODA,OPIS,CENA,PROIZVODJAC,STANJE_PROIZVODA) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
       
        

        
        


        private void button4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE KATALOG_PROIZVODA SET NAZIV_PROIZVODA= '" + textBox2.Text + "', OPIS= '" + textBox3.Text + "' , CENA= '" + textBox4.Text + "', PROIZVODJAC= '" + textBox5.Text + "' , STANJE_PROIZVODA='" + textBox6.Text + "' where KATALOG_ID= " + textBox1.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from  KATALOG_PROIZVODA";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

      


        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Izbor Izbor = new Izbor ();
            Izbor.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into PROIZVOD (PROIZVOD_ID,PRODAVAC_PR_ID, FAKTURA_ID, KLIJENT_ID, KATALOG_ID,NAZIV_PROIZVODA,TIP_PROIZVODA,CENA,KOLIČINA,VREDNOST) values ('" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "','" + textBox11.Text + "', '" + textBox19.Text + "', '" + textBox20.Text + "', '" + textBox21.Text + "','" + textBox22.Text + "', '" + textBox23.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE PROIZVOD SET KATALOG_ID= '" + textBox11.Text + "', NAZIV_PROIZVODA= '" + textBox19.Text + "', TIP_PROIZVODA= '" + textBox20.Text + "' , CENA= '" + textBox21.Text + "',KOLIČINA= '" + textBox22.Text + "', VREDNOST='" + textBox23.Text + "' where PROIZVOD_ID= " + textBox7.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM PROIZVOD where PROIZVOD_ID= " + textBox7.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from PROIZVOD";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox7.Text = row.Cells[0].Value.ToString();
                textBox8.Text = row.Cells[1].Value.ToString();
                textBox9.Text = row.Cells[2].Value.ToString();
                textBox10.Text = row.Cells[3].Value.ToString();
                textBox11.Text = row.Cells[4].Value.ToString();
                textBox19.Text = row.Cells[5].Value.ToString();
                textBox20.Text = row.Cells[6].Value.ToString();
                textBox21.Text = row.Cells[7].Value.ToString();
                textBox22.Text = row.Cells[8].Value.ToString();
                textBox23.Text = row.Cells[9].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox12.Text = row.Cells[0].Value.ToString();
                textBox13.Text = row.Cells[1].Value.ToString();
                textBox14.Text = row.Cells[3].Value.ToString();
                textBox15.Text = row.Cells[4].Value.ToString();
               
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView4.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox16.Text = row.Cells[0].Value.ToString();
                textBox17.Text = row.Cells[1].Value.ToString();
                textBox18.Text = row.Cells[2].Value.ToString();
                textBox24.Text = row.Cells[4].Value.ToString();
               
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView5.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox25.Text = row.Cells[0].Value.ToString();
                textBox26.Text = row.Cells[1].Value.ToString();
                textBox27.Text = row.Cells[2].Value.ToString();
                
                
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView7.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox30.Text = row.Cells[0].Value.ToString();
                textBox31.Text = row.Cells[1].Value.ToString();
                textBox32.Text = row.Cells[2].Value.ToString();
                textBox33.Text = row.Cells[3].Value.ToString();
                

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into FAKTURA (FAKTURA_ID,PRODAVAC_PR_ID,OPIS,CENA) values ('" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', '" + textBox15.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE  FAKTURA SET PRODAVAC_PR_ID= '" + textBox13.Text + "', OPIS= '" + textBox14.Text + "', CENA= '" + textBox15.Text + "'  where FAKTURA_ID= " + textBox12.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM FAKTURA where FAKTURA_ID= " + textBox12.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from FAKTURA";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into NARUDZBENICA (NARUDZBENICA_ID,KLIJENT_ID,STATUS,VREDNOST) values ('" + textBox16.Text + "', '" + textBox17.Text + "', '" + textBox18.Text + "', '" + textBox24.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE NARUDZBENICA SET KLIJENT_ID= " + textBox17.Text + ", STATUS= '" + textBox18.Text + "', VREDNOST= '" + textBox24.Text + "'  where NARUDZBENICA_ID= " + textBox16.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM NARUDZBENICA where NARUDZBENICA_ID= " + textBox16.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from NARUDZBENICA";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into PRODAVAC_IT_PROIZVODA (PRODAVAC_PR_ID,IME,PREZIME) values ('" + textBox25.Text + "', '" + textBox26.Text + "', '" + textBox27.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE PRODAVAC_IT_PROIZVODA SET IME= '" + textBox26.Text + "', PREZIME= '" + textBox27.Text + "'  where PRODAVAC_PR_ID= " + textBox25.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM PRODAVAC_IT_PROIZVODA where PRODAVAC_PR_ID= " + textBox25.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from PRODAVAC_IT_PROIZVODA";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into KLIJENT (KLIJENT_ID,NAZIV,SEDISTE,VLASNIK) values ('" + textBox30.Text + "', '" + textBox31.Text + "', '" + textBox32.Text + "', '" + textBox33.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno sačuvani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće sačuvati" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " UPDATE  KLIJENT SET NAZIV= '" + textBox31.Text + "', SEDISTE= '" + textBox32.Text + "', VLASNIK= '" + textBox33.Text + "' where KLIJENT_ID= " + textBox30.Text + "";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci uspešno izmenjeni!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće izmeniti podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = " DELETE FROM KLIJENT where KLIJENT_ID= " + textBox30.Text + "";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su obrisani!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemoguće obrisati podatke" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string query = "select * from KLIJENT";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView7.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from KATALOG_PROIZVODA where NAZIV_PROIZVODA='" + textBox2.Text + "'";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from KATALOG_PROIZVODA where CENA=" + textBox4.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from KATALOG_PROIZVODA where PROIZVODJAC='" + textBox5.Text + "' ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PROIZVOD where FAKTURA_ID=" + textBox9.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PROIZVOD where PRODAVAC_PR_ID= " + textBox8.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PROIZVOD where KLIJENT_ID=" + textBox10.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PROIZVOD where TIP_PROIZVODA='" + textBox20.Text + "'";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  FAKTURA where PRODAVAC_PR_ID=" + textBox13.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  NARUDZBENICA where KLIJENT_ID=" + textBox17.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PRODAVAC_IT_PROIZVODA where IME='" + textBox26.Text + "' ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  PRODAVAC_IT_PROIZVODA where PREZIME='" + textBox27.Text + "' ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from  KLIJENT where SEDISTE='" + textBox32.Text + "' ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView7.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from PROIZVOD where FAKTURA_ID=" + textBox9.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from PROIZVOD where KLIJENT_ID=" + textBox10.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from PROIZVOD where PRODAVAC_PR_ID=" + textBox8.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from FAKTURA where PRODAVAC_PR_ID=" + textBox13.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = conn;

                string query = "select * from NARUDZBENICA where KLIJENT_ID=" + textBox17.Text + " ";

                cmd.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
       
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
           
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox24.Clear();
           
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            
        }
    }
    }

