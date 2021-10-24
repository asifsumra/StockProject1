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
    public partial class Form9 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pos.accdb;Persist Security Info=True";
        string nname, ddate, ccompany, pparty, oorder, kkg, PpCS, ppprice, ccprice, wwprice, rrprice, bbilln;//, qquantity;
        

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            nname = textBox1.Text;
            ddate = textBox2.Text;
            ccompany = textBox3.Text;
            pparty = textBox4.Text;
            oorder = textBox5.Text;
            kkg = textBox6.Text;
            PpCS = textBox7.Text;
            ppprice = textBox8.Text;
            ccprice = textBox9.Text;
            wwprice = textBox10.Text;
            rrprice = textBox11.Text;
            bbilln = textBox12.Text;
            //qquantity = textBox13.Text;

            //SqlConnection connection = new SqlConnection(connectionString);
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            try
            {
                string query = "UPDATE prod SET tareekh=@tareekh,company=@company,party=@party,hukam=@hukam,kg=@kg,PCS=@PCS,pprice=@pprice,cprice=@cprice,wprice=@wprice,rprice=@rprice,billn=@billn WHERE namee=@namee";
                //SqlCommand cmmd = new SqlCommand(query, connection);
                OleDbCommand cmmd = new OleDbCommand(query, connection);
                //cmmd.Parameters.AddWithValue("@namee", nname);
                cmmd.Parameters.AddWithValue("@tareekh", ddate);
                cmmd.Parameters.AddWithValue("@company", ccompany);
                cmmd.Parameters.AddWithValue("@party", pparty);
                cmmd.Parameters.AddWithValue("@hukam", oorder);
                cmmd.Parameters.AddWithValue("@kg", kkg);
                cmmd.Parameters.AddWithValue("@PCS", PpCS);
                cmmd.Parameters.AddWithValue("@pprice", ppprice);
                cmmd.Parameters.AddWithValue("@cprice", ccprice);
                cmmd.Parameters.AddWithValue("@wprice", wwprice);
                cmmd.Parameters.AddWithValue("@rprice", rrprice);
                cmmd.Parameters.AddWithValue("@billn", bbilln);
                //cmmd.Parameters.AddWithValue("@quantity", qquantity);
                cmmd.Parameters.AddWithValue("@namee", nname);
                int result = cmmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfully ");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = nname;
            textBox2.Text = ddate;
            textBox3.Text = ccompany;
            textBox4.Text = pparty;
            textBox5.Text = oorder;
            textBox6.Text = kkg;
            textBox7.Text = PpCS;
            textBox8.Text = ppprice;
            textBox9.Text = ccprice;
            textBox10.Text = wwprice;
            textBox11.Text = rrprice;
            textBox12.Text = bbilln;
            //textBox13.Text = qquantity;
        }

        public Form9(string namee,string tareekh,string company,string party,string hukam,string kg,string PCS,string pprice,string cprice,string wprice,string rprice,string billn)//,//string quantity)
        {
            InitializeComponent();
            nname = namee;
            ddate = tareekh;
            ccompany = company;
            pparty = party;
            oorder = hukam;
            kkg = kg;
            PpCS = PCS;
            ppprice = pprice;
            ccprice = cprice;
            wwprice = wprice;
            rrprice = rprice;
            bbilln = billn;
            //qquantity = quantity;
        }
    }
}
