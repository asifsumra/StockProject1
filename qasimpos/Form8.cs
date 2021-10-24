using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace qasimpos
{
    public partial class Form8 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pos.accdb;Persist Security Info=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            getdatafromdb();
        }

        public void getdatafromdb()
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            try
            {
                string query = "SELECT * FROM prod";
                //SqlCommand cmmd = new SqlCommand(query, connection);
                //SqlDataAdapter adapterr = new SqlDataAdapter(cmmd);
                OleDbCommand cmmd = new OleDbCommand(query, connection);
                OleDbDataAdapter adapterr = new OleDbDataAdapter(cmmd);

                DataTable dtt = new DataTable();
                adapterr.Fill(dtt);
                dataGridView12.DataSource = dtt;
                label2.Text = $"Total Records: {dataGridView12.RowCount}";
                
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
}
