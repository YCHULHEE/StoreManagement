using StoreManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Customer_List n = new Customer_List();
            n.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
