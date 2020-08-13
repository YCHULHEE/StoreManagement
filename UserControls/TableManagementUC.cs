using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace StoreManagement.UserControls
{
    public partial class TableManagementUC : UserControl
    {
        public TableManagementUC()
        {
            InitializeComponent();
        }

       

        private void TableManagementUC_Load(object sender, EventArgs e)
        {

        }

        private void table1_Click(object sender, EventArgs e)
        {
            tableText.Text = ("1번 테이블");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
