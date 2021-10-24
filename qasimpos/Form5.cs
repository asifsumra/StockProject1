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
using System.IO;
using System.Data.OleDb;

namespace qasimpos
{
    public partial class Form5 : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pos.mdf;Integrated Security=True";
       
        //static string path = Path.GetFullPath(Environment.CurrentDirectory);
        //static string databaseName = "mypos.mdf";
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pos.accdb;Persist Security Info=True";
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @"\" + databaseName + "; Integrated Security=True";
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachFilename=" + path + @"\" + databaseName + "; Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? You Want to Exit?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            //SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string query = "SELECT COUNT(*) FROM login WHERE username='"+ textuser.Text + "'AND password='" + textpass.Text + "'";
                OleDbCommand cmmd = new OleDbCommand(query, connection);
                //SqlCommand cmmd = new SqlCommand(query, connection);
                //SqlDataAdapter adapterr = new SqlDataAdapter(cmmd);
                OleDbDataAdapter adapterr = new OleDbDataAdapter(cmmd);
                DataTable dttt = new DataTable();
                adapterr.Fill(dttt);
                if(dttt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form1 oo = new Form1();
                    oo.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
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

        private void button2_Click(object sender, EventArgs e)
        {
            textuser.Clear();
            textpass.Clear();
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textpass.PasswordChar == '*')
            {
                button3.BringToFront();
                textpass.PasswordChar = '\0';
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textpass.PasswordChar == '\0')
            {
                button4.BringToFront();
                textpass.PasswordChar = '*';
            }
        }

        private void textpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
