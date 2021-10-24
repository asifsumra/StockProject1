using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qasimpos
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel222.Width += 3;

            if(panel222.Width >= 599)
            {
                timer1.Stop();
                Form5 fm5 = new Form5();
                fm5.Show();
                this.Hide();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
