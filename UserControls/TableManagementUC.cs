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
    enum Human
    {
        Kid, Adult
    }

    public partial class TableManagementUC : UserControl
    {
        TableInfo[] tb = new TableInfo[15];
        TableInfo temp = new TableInfo();

        public TableManagementUC()
        {
            InitializeComponent();
            DataManager.Load_TableInfo();
            for (int i = 0; i < 15; i++)
            {
                tb[i] = new TableInfo();
                tb[i].tableNumber = i + 1;
            }
        }

        private void Amount_Control_up(TableInfo[] tb, int value, Human human)
        {
            for (int i = 0; i < 15; i++)
            {
                if (tb[i].check == 1)
                {
                    if (tb[i].tableName == temp.tableName)
                    {
                        if (human == Human.Kid)
                            tb[i].kidNumber++;
                        else if (human == Human.Adult)
                            tb[i].adultNumber++;

                        tb[i].price += value;
                        temp = tb[i];
                    }
                }
            }
        }

        private void Amount_Control_Down(TableInfo[] tb, int value, Human human)
        {
            for (int i = 0; i < 15; i++)
            {
                if (tb[i].check == 1)
                {
                    if (tb[i].tableName == temp.tableName)
                    {
                        if (human == Human.Kid && tb[i].kidNumber > 0)
                        {
                            tb[i].kidNumber--;
                            tb[i].price -= value;
                        }
                        else if (human == Human.Adult && tb[i].adultNumber > 0)
                        {
                            tb[i].adultNumber--;
                            tb[i].price -= value;
                        }
                        temp = tb[i];
                    }
                }
            }
        }

        private void Print_info(TableInfo table_info, Button table)
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
            table_info.check = 1;

            table.Text = ($"{table_info.tableNumber}번 테이블\n입실시간 {table_info.inTime.Hour}시 {table_info.inTime.Minute}분" +
                $"\n아동 {table_info.kidNumber}명\n성인 {table_info.adultNumber}명\n가격 {table_info.price}원\n");
        }

        private void Print_info(TableInfo table_info, Label table)
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
        }
        
        private void TableManagementUC_Load(object sender, EventArgs e)
        {

        }

        private void table1_Click(object sender, EventArgs e)
        {
            /*table1.Text = $"{tb1.inTime.Hour}";*/
            Print_info(tb[0], table1);
            temp = tb[0];
            Print_info(temp, label_last);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void table2_Click(object sender, EventArgs e)
        {
            Print_info(tb[1], table2);
            temp = tb[1];
            Print_info(temp, label_last);
        }

        private void table3_Click(object sender, EventArgs e)
        {
            Print_info(tb[2], table3);
            temp = tb[2];
            Print_info(temp, label_last);
        }

        private void table4_Click(object sender, EventArgs e)
        {
            Print_info(tb[3], table4);
            temp = tb[3];
            Print_info(temp, label_last);
        }

        private void table5_Click(object sender, EventArgs e)
        {
            Print_info(tb[4], table5);
            temp = tb[4];
            Print_info(temp, label_last);
        }

        private void table6_Click(object sender, EventArgs e)
        {
            Print_info(tb[5], table6);
            temp = tb[5];
            Print_info(temp, label_last);
        }

        private void table7_Click(object sender, EventArgs e)
        {
            Print_info(tb[6], table7);
            temp = tb[6];
            Print_info(temp, label_last);
        }

        private void table8_Click(object sender, EventArgs e)
        {
            Print_info(tb[7], table8);
            temp = tb[7];
            Print_info(temp, label_last);
        }

        private void table9_Click(object sender, EventArgs e)
        {
            Print_info(tb[8], table9);
            temp = tb[8];
            Print_info(temp, label_last);
        }

        private void table10_Click(object sender, EventArgs e)
        {
            Print_info(tb[9], table10);
            temp = tb[9];
            Print_info(temp, label_last);
        }

        private void table11_Click(object sender, EventArgs e)
        {
            Print_info(tb[10], table11);
            temp = tb[10];
            Print_info(temp, label_last);
        }

        private void table12_Click(object sender, EventArgs e)
        {
            Print_info(tb[11], table12);
            temp = tb[11];
            Print_info(temp, label_last);
        }

        private void table13_Click(object sender, EventArgs e)
        {
            Print_info(tb[12], table13);
            temp = tb[12];
            Print_info(temp, label_last);
        }

        private void table14_Click(object sender, EventArgs e)
        {
            Print_info(tb[13], table14);
            temp = tb[13];
            Print_info(temp, label_last);
        }

        private void table15_Click(object sender, EventArgs e)
        {
            Print_info(tb[14], table15);
            temp = tb[14];
            Print_info(temp, label_last);
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("결제하시겠습니까?", "결제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 네
                if (temp.tableName.Trim() != "")
                {
                    try
                    {
                        temp.outTime = DateTime.Now;
                        DataManager.TableInfos.Add(temp);
                        DataManager.Save_TableInfo();
                        foreach (var item in Controls)
                        {
                            if (item is Button)
                            {
                                if ((item as Button).Name == temp.tableName)
                                {
                                    for (int i = 0; i < 15; i++)
                                    {
                                        if (temp.tableName == tb[i].tableName)
                                        {
                                            tb[i] = new TableInfo();
                                            tb[i].tableNumber = i + 1;
                                            (item as Button).Text = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                    }
                }
                else
                {
                    MessageBox.Show("누락된 테이블 정보가 있습니다.");
                }
            }
        }

        private void tableText_Click(object sender, EventArgs e)
        {

        }

        private void button_kid_up_Click(object sender, EventArgs e)
        {
            Amount_Control_up(tb, 8000, Human.Kid);
            Print_info(temp, label_last);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    foreach (var item in Controls)
                    {
                        if (item is Button)
                        {
                            if ((item as Button).Name == tb[i].tableName)
                            {
                                Print_info(tb[i], item as Button);
                            }
                        }
                    }
                }
            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.Message);
                Console.WriteLine(eee.StackTrace);
            }
        }

        private void button_kid_down_Click(object sender, EventArgs e)
        {
            Amount_Control_Down(tb, 8000, Human.Kid);
            Print_info(temp, label_last);
        }

        

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 네
                foreach (var item in Controls)
                {
                    if (item is Button)
                    {
                        if ((item as Button).Name == temp.tableName)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                if (temp.tableName == tb[i].tableName)
                                {
                                    tb[i] = new TableInfo();
                                    tb[i].tableNumber = i + 1;
                                    (item as Button).Text = "";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // 아니요
            }  
        }

        private void button_adult_up_Click(object sender, EventArgs e)
        {
            Amount_Control_up(tb, 21900, Human.Adult);
            Print_info(temp, label_last);
        }

        private void button_adult_down_Click(object sender, EventArgs e)
        {
            Amount_Control_Down(tb, 21900, Human.Adult);
            Print_info(temp, label_last);
        }
    }
}
