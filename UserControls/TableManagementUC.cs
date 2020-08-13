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

        TableInfo tb1 = new TableInfo();
        TableInfo tb2 = new TableInfo();
        TableInfo tb3 = new TableInfo();
        TableInfo tb4 = new TableInfo();
        TableInfo tb5 = new TableInfo();
        TableInfo tb6 = new TableInfo();
        TableInfo tb7 = new TableInfo();
        TableInfo tb8 = new TableInfo();
        TableInfo tb9 = new TableInfo();
        TableInfo tb10 = new TableInfo();
        TableInfo tb11 = new TableInfo();
        TableInfo tb12 = new TableInfo();
        TableInfo tb13 = new TableInfo();
        TableInfo tb14 = new TableInfo();
        TableInfo tb15 = new TableInfo();
        TableInfo temp = new TableInfo();


        private void print_info(TableInfo table_info, Button table)
        {
            table_info.tableName = table.Name;

            if (table_info.price <= 0)
            {
                table_info.price = 0;
            }
            if (table_info.kidNumber <= 0)
            {
                table_info.kidNumber = 0;
            }
            if (table_info.adultNumber <= 0)
            {
                table_info.adultNumber = 0;
            }
            if (table_info.inTime.Hour == 0)
            {
                table_info.inTime = DateTime.Now;
            }
            table.Text = ($"{table_info.tableNumber}번 테이블\n입실시간 {table_info.inTime.Hour}시 {table_info.inTime.Minute}분" +
                $"\n아동 {table_info.kidNumber}명\n성인 {table_info.adultNumber}명\n가격 {table_info.price}원\n");
            temp = table_info;
        }

        private void print_info(TableInfo table_info, Label table)
        {
            if (table_info.price <= 0)
            {
                table_info.price = 0;
            }
            if (table_info.kidNumber <= 0)
            {
                table_info.kidNumber = 0;
            }
            if (table_info.adultNumber <= 0)
            {
                table_info.adultNumber = 0;
            }
            if (table_info.inTime.Hour == 0)
            {
                table_info.inTime = DateTime.Now;
            }
            table.Text = ($"{table_info.tableNumber}번 테이블\n입실시간 {table_info.inTime.Hour}시 {table_info.inTime.Minute}분" +
                $"\n아동 {table_info.kidNumber}명\n성인 {table_info.adultNumber}명\n가격 {table_info.price}원\n");
            temp = table_info;
        }

        /* private void print_info(TableInfo table_info, Button table)
         {
             table.Text = ($"{table_info.tableNumber}번 테이블\n입실 시간 {table_info.inTime.Hour}시" +
                $" {table_info.inTime.Minute}분\n사람 {table_info.PeopleNumber}명\n가격 {table_info.price}원\n");
         }
 */



        private void TableManagementUC_Load(object sender, EventArgs e)
        {

        }

        private void table1_Click(object sender, EventArgs e)
        {
            tb1.tableNumber = 1;
            /*table1.Text = $"{tb1.inTime.Hour}";*/
            print_info(tb1, table1);
            print_info(temp, label_last);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void table2_Click(object sender, EventArgs e)
        {
            tb2.tableNumber = 2;
            print_info(tb2, table2);

        }

        private void table3_Click(object sender, EventArgs e)
        {
            tb3.tableNumber = 3;
            print_info(tb3, table3);
        }

        private void table4_Click(object sender, EventArgs e)
        {
            tb4.tableNumber = 4;
            print_info(tb4, table4);
        }

        private void table5_Click(object sender, EventArgs e)
        {
            tb5.tableNumber = 5;
            print_info(tb5, table5);
        }

        private void table6_Click(object sender, EventArgs e)
        {
            tb6.tableNumber = 6;
            print_info(tb6, table6);
        }

        private void table7_Click(object sender, EventArgs e)
        {
            tb7.tableNumber = 7;
            print_info(tb7, table7);
        }

        private void table8_Click(object sender, EventArgs e)
        {
            tb8.tableNumber = 8;
            print_info(tb8, table8);
        }

        private void table9_Click(object sender, EventArgs e)
        {
            tb9.tableNumber = 9;
            print_info(tb9, table9);
        }

        private void table10_Click(object sender, EventArgs e)
        {
            tb10.tableNumber = 10;
            print_info(tb10, table10);
        }

        private void table11_Click(object sender, EventArgs e)
        {
            tb11.tableNumber = 11;
            print_info(tb11, table11);
        }

        private void table12_Click(object sender, EventArgs e)
        {
            tb12.tableNumber = 12;
            print_info(tb12, table12);
        }

        private void table13_Click(object sender, EventArgs e)
        {
            tb13.tableNumber = 13;
            print_info(tb13, table13);
        }

        private void table14_Click(object sender, EventArgs e)
        {
            tb14.tableNumber = 14;
            
            print_info(tb14, table14);
        }

        private void table15_Click(object sender, EventArgs e)
        {
            tb15.tableNumber = 15;
            print_info(tb15, table15);
        }

        private void button_action_Click(object sender, EventArgs e)
        {
           
        }

        private void tableText_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if ((item as TableInfo).tableName == temp.tableName)
                {
                    (item as TableInfo).kidNumber++;
                    (item as TableInfo).price += 8000;
                    
                }
            }
        }
    }
}
