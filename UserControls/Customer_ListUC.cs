using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.UserControls
{
    public partial class Customer_ListUC : UserControl
    {
        int search_count = 0;
        public Customer_ListUC()
        {
            InitializeComponent();
            DataManager.Load_Customers();
            dataGridView_Customer_manage.DataSource = DataManager.Customers;
            textBox_Name.Text = DataManager.Customers[0].m_Name;
            textBox_Sex.Text = DataManager.Customers[0].m_Sex;
            textBox_Phonenum.Text = DataManager.Customers[0].m_PhoneNum;
            textBox_Birthday.Text = DataManager.Customers[0].m_Birthday.ToString();
            textBox_Enterdate.Text = DataManager.Customers[0].m_Regdate.ToString();
        }

        private void dataGridView_Customer_manage_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정

                Customer customer = dataGridView_Customer_manage.CurrentRow.DataBoundItem as Customer;
                textBox_Name.Text = customer.m_Name;
                textBox_Sex.Text = customer.m_Sex;
                textBox_Phonenum.Text = customer.m_PhoneNum;
                textBox_Birthday.Text = customer.m_Birthday.ToString();
                textBox_Enterdate.Text = customer.m_Regdate.ToString();
            }
            catch (Exception Except)
            {

            }
        }

        private void button_Manage_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Birthday.Text.Trim() != "" && textBox_Enterdate.Text.Trim() != ""
                 && textBox_Name.Text.Trim() != "" && textBox_Phonenum.Text.Trim() != ""
                 && textBox_Sex.Text.Trim() != "")
            {

                bool isDuplicate = false;
                foreach (var item in DataManager.Customers)
                {
                    if (item.m_PhoneNum == textBox_Phonenum.Text)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    MessageBox.Show("해당 연락처의 회원 정보는 이미 존재합니다.");
                }
                else
                {
                    try
                    {
                        Customer temp = new Customer();
                        temp.m_Name = textBox_Name.Text;
                        temp.m_Sex = textBox_Sex.Text;
                        temp.m_PhoneNum = textBox_Phonenum.Text;
                        temp.m_Birthday = textBox_Birthday.Text;
                        temp.m_Regdate = DateTime.Now;
                        DataManager.Customers.Add(temp);
                        DataManager.PrintLog($"{textBox_Phonenum.Text} 회원 추가 완료");
                        dataGridView_Customer_manage.DataSource = null;
                        dataGridView_Customer_manage.DataSource = DataManager.Customers;
                        DataManager.Save_Customers();
                        string contents = $"회원 {temp.m_Name}님이 회원 목록에 추가되었습니다.";
                        WriteLog(contents);
                    }
                    catch (Exception except)
                    {
                        Console.WriteLine(" catch (Exception except) - except.Message : " + except.Message);
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("누락된 회원 정보가 있습니다.");
            }
        }

        private void button_Manage_Delete_Click(object sender, EventArgs e)
        {

            if (textBox_Phonenum.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Customers)
                {
                    if (item.m_PhoneNum == textBox_Phonenum.Text)
                    {
                        isDuplicate = true;
                        DataManager.Customers.Remove(item);
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 회원의 정보가 존재하지 않습니다.");
                }
                else
                {

                    try
                    {
                        Customer temp = new Customer();
                        temp.m_Name = textBox_Name.Text;
                        string contents = $"회원 {temp.m_Name}님이 회원 목록에서 삭제되었습니다.";
                        WriteLog(contents);

                        DataManager.PrintLog($"{textBox_Phonenum.Text} 회원 정보 제거 완료");
                        dataGridView_Customer_manage.DataSource = null;
                        dataGridView_Customer_manage.DataSource = DataManager.Customers;
                        DataManager.Save_Customers();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("연락처 부분이 공백입니다.");
            }
        }

        private void button_Manage_Modify_Click(object sender, EventArgs e)
        {
            if (textBox_Birthday.Text.Trim() != "" && textBox_Enterdate.Text.Trim() != ""
                 && textBox_Name.Text.Trim() != "" && textBox_Phonenum.Text.Trim() != ""
                 && textBox_Sex.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Customers)
                {
                    if (item.m_PhoneNum == textBox_Phonenum.Text)
                    {
                        item.m_Name = textBox_Name.Text;
                        item.m_Sex = textBox_Sex.Text;
                        item.m_PhoneNum = textBox_Phonenum.Text;
                        item.m_Birthday = textBox_Birthday.Text;
                        item.m_Regdate = DateTime.Now;
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("(수정)해당 회원의 정보가 존재하지 않습니다.");
                }
                else
                {
                    try
                    {
                        DataManager.PrintLog($"{textBox_Phonenum.Text} 회원 수정 완료");
                        dataGridView_Customer_manage.DataSource = null;
                        dataGridView_Customer_manage.DataSource = DataManager.Customers;
                        DataManager.Save_Customers();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("(수정)누락된 학생 정보가 있습니다.");
            }
        }

        private void button_Manage_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Phonenum.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Customers)
                {
                    if (item.m_PhoneNum == textBox_Phonenum.Text)
                    {
                        string format = $"연락처가 {item.m_PhoneNum}인 분의 정보입니다.{Environment.NewLine}" +
                            $"이름 : {item.m_Name}" + Environment.NewLine +
                            $"성별 : {item.m_Sex}" + Environment.NewLine +
                            $"연락처 : {item.m_PhoneNum}" + Environment.NewLine +
                            $"생일 : {item.m_Birthday}" + Environment.NewLine +
                            $"등록 일시 : {item.m_Regdate}";
                        MessageBox.Show(format);
                        DataManager.PrintLog(format);
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 회원의 정보가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("(조회)연락처 부분이 공백입니다.");
            }
        }

        private void WriteLog(string contents)
        {
            string logContents = "[" + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss") + "] " + contents; //연/월/일 시:분:초 형식으로 로그찍기
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_Changes_Recode.Items.Insert(0, logContents);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            List<Customer> list_search = new List<Customer>();

            if (textBox_Search.Text.Trim() != "")
            {
                bool flag = false;
                foreach (var item in DataManager.Customers)
                {
                    if (item.m_Name == textBox_Search.Text)
                    {
                        list_search.Add(item);
                        search_count++;
                        flag = true;
                    }
                }
                if (flag)
                {
                    label_search_result.Text = $"회원님과 같은 이름으로 등록된 건수 : {search_count.ToString()}";
                    try
                    {
                        dataGridView_Customer_Search.DataSource = null;
                        dataGridView_Customer_Search.DataSource = list_search;
                        search_count = 0;

                    }
                    catch (Exception except)
                    {

                    }
                }
            }
            else
            {
                dataGridView_Customer_Search.DataSource = null;
                dataGridView_Customer_Search.DataSource = DataManager.Customers;
            }
        }
    }
}
