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

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            reservationUC1.Visible = true;
            customer_List1.Visible = false;
            tableManagementUC1.Visible = false;
            graphUC1.Visible = false;
        }

        private void button_member_Click(object sender, EventArgs e)
        {
            reservationUC1.Visible = false;
            customer_List1.Visible = true;
            tableManagementUC1.Visible = false;
            graphUC1.Visible = false;
        }

        private void button_table_Click(object sender, EventArgs e)
        {
            reservationUC1.Visible = false;
            customer_List1.Visible = false;
            tableManagementUC1.Visible = true;
            graphUC1.Visible = false;
        }

        private void button_grape_Click(object sender, EventArgs e)
        {
            reservationUC1.Visible = false;
            customer_List1.Visible = false;
            tableManagementUC1.Visible = false;
            graphUC1.Visible = true;
        }

        private void button_shutdown_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
