using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_reservation;

namespace StoreManagement.UserControls
{
    public partial class ReservationUC : UserControl
    {
        public int adults;
        public int kids;
        public ReservationUC()
        {
            InitializeComponent();
            DataManager.Load_Reservations();
            dataGridView_reservation.DataSource = DataManager.Reservations;

            textBox_name.Text = DataManager.Reservations[0].mName;
            textBox_phone_number.Text = DataManager.Reservations[0].mphone_number;
            textBox_person.Text = DataManager.Reservations[0].mperson;
            textBox_time.Text = DataManager.Reservations[0].mtime.ToString();
            textBox_table_number.Text = DataManager.Reservations[0].mtable_number.ToString();
            //DataTable table = new DataTable();
            //table.Columns.Add("예약자성함", typeof(string));
            //table.Columns.Add("전화번호", typeof(string));
            //table.Columns.Add("예약시간", typeof(string));
            //table.Columns.Add("테이블번호", typeof(string));
            //table.Columns.Add("예약통화한시간", typeof(string));



        }

        private void dataGridView_reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Reservation reservation = dataGridView_reservation.CurrentRow.DataBoundItem as Reservation;

                textBox_name.Text = reservation.mName;
                textBox_phone_number.Text = reservation.mphone_number.ToString();
                textBox_person.Text = reservation.mperson;
                textBox_time.Text = reservation.mtime.ToString();
                textBox_table_number.Text = reservation.mtable_number.ToString();

            }
            catch (Exception Except)
            {

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Trim() != "" && textBox_phone_number.Text.Trim() != ""
              && textBox_time.Text.Trim() != "" && textBox_table_number.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Reservations)
                {
                    if (item.mphone_number == textBox_phone_number.Text)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    MessageBox.Show("해당 예약자의 전화번호가 이미 존재합니다.");
                }
                else
                {
                    try
                    {
                        Reservation temp = new Reservation();
                        temp.mName = textBox_name.Text;
                        temp.mphone_number = textBox_phone_number.Text;
                        temp.mperson = textBox_person.Text;
                        string temptime = "";
                        temptime = textBox_time.Text;
                        temp.mtime = temptime;
                        temp.mtable_number = textBox_table_number.Text;
                        temp.RegDate = DateTime.Now;
                        DataManager.Reservations.Add(temp);
                        DataManager.PrintLog($"{textBox_phone_number.Text} 예약자 추가 완료");
                        dataGridView_reservation.DataSource = null;
                        dataGridView_reservation.DataSource = DataManager.Reservations;

                        DataManager.Save_Reservations();

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
                MessageBox.Show("누락된 예약자 정보가 있습니다.");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_phone_number.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Reservations)
                {
                    if (item.mphone_number == textBox_phone_number.Text)
                    {
                        isDuplicate = true;
                        DataManager.Reservations.Remove(item);
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 예약자의 정보가 존재하지 않습니다.");
                }
                else
                {

                    try
                    {
                        DataManager.PrintLog($"{textBox_phone_number.Text} 예약자 정보 제거 완료");
                        dataGridView_reservation.DataSource = null;
                        dataGridView_reservation.DataSource = DataManager.Reservations;
                        DataManager.Save_Reservations();

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
                MessageBox.Show("예약 부분이 공백입니다. 꼼꼼히 적어주십시오^___^");
            }
        }

       

        private void button_adults_add_Click(object sender, EventArgs e)
        {
            adults++;
            textBox_person.Text = "성인" + adults + "아동" + kids;
        }

        private void button_adults_del_Click(object sender, EventArgs e)
        {
            adults--;
            if (adults < 0)
            {
                adults = 0;
            }
            textBox_person.Text = "성인" + adults + "아동" + kids;

        }

        private void button_kids_add_Click(object sender, EventArgs e)
        {
            kids++;
            textBox_person.Text = "성인" + adults + "아동" + kids;
        }

        private void button_kids_del_Click(object sender, EventArgs e)
        {
            kids--;
            if (kids < 0)
            {
                kids = 0;
            }
            textBox_person.Text = "성인" + adults + "아동" + kids;
        }


        private void button_reset_Click(object sender, EventArgs e)
        {

            adults = 0;
            kids = 0;
            textBox_name.Text = "";
            textBox_phone_number.Text = "";
            textBox_person.Text = "";
            textBox_time.Text = "";
            textBox_table_number.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_person_Click(object sender, EventArgs e)
        {

        }

        private void textBox_person_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox_table_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_table_number_Click(object sender, EventArgs e)
        {

        }

        private void label_reservation_time_Click(object sender, EventArgs e)
        {

        }

        private void label_phone_number_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }
    }
}
