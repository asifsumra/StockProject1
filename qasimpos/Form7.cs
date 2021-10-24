using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace qasimpos
{
    public partial class Form7 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pos.accdb;Persist Security Info=True";
        public Form7()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        public void getdatafromdb()
        {
            //OleDbConnection connection = new OleDbConnection(connectionString);
            //SqlConnection connection = new SqlConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            try
            {
                string query = "SELECT * FROM prod";
                //SqlCommand cmmd = new SqlCommand(query, connection);
                OleDbCommand cmmd = new OleDbCommand(query, connection);
                //SqlDataAdapter adapterr = new SqlDataAdapter(cmmd);
                OleDbDataAdapter adapterr = new OleDbDataAdapter(cmmd);

                DataTable dtt = new DataTable();
                adapterr.Fill(dtt);
                dataGridView11.DataSource = dtt;
                label22.Text = $"Total Records: {dataGridView11.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView11.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are You Sure You Want To Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {


                    string id;
                    id = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["NameeColumn"].Value);
                    //SqlConnection connection = new SqlConnection(connectionString);
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    connection.Open();
                    try
                    {
                        string query = "DELETE FROM prod WHERE namee=@namee";
                        //SqlCommand cmmd = new SqlCommand(query, connection);
                        OleDbCommand cmmd = new OleDbCommand(query, connection);
                        cmmd.Parameters.AddWithValue("@namee", id);
                        int result = cmmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully ");
                            getdatafromdb();
                        }
                        else
                        {
                            MessageBox.Show("Not Deleted");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            //code for update
            if(dataGridView11.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string namee, tareekh, company, party, hukam, kg, PCS, pprice, cprice, wprice, rprice, billn;
                namee = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["NameeColumn"].Value);
                tareekh = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["tareekhColumn"].Value);
                company = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["CompanyColumn"].Value);
                party = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["PartyColumn"].Value);
                hukam = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["hukamColumn"].Value);
                kg = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["KgColumn"].Value);
                PCS = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["PcsColumn"].Value);
                pprice = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["PpriceColumn"].Value);
                cprice = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["CpriceColumn"].Value);
                wprice = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["WpriceColumn"].Value);
                rprice = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["RpriceColumn"].Value);
                billn = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["BillnColumn"].Value);
                //quantity = Convert.ToString(dataGridView11.Rows[e.RowIndex].Cells["QuantityColumn"].Value);

                Form9 formN = new Form9(namee, tareekh, company, party, hukam, kg, PCS, pprice, cprice, wprice, rprice, billn);
                formN.ShowDialog();
                getdatafromdb();

            }

        }

        private void Form7_Activated(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            getdatafromdb();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //SqlConnection connection = new SqlConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            try
            {
                string query = "SELECT * FROM prod WHERE namee like '%" + textBox2.Text + "%' ";
                //SqlCommand cmmd = new SqlCommand(query, connection);
                //SqlDataAdapter adapterr = new SqlDataAdapter(cmmd);
                OleDbCommand cmmd = new OleDbCommand(query, connection);
                OleDbDataAdapter adapterr = new OleDbDataAdapter(cmmd);

                DataTable dtt = new DataTable();
                adapterr.Fill(dtt);
                dataGridView11.DataSource = dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
