namespace StoreManagement.UserControls
{
    partial class ReservationUC
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_kids_del = new System.Windows.Forms.Button();
            this.button_kids_add = new System.Windows.Forms.Button();
            this.button_adults_del = new System.Windows.Forms.Button();
            this.label_person = new System.Windows.Forms.Label();
            this.textBox_person = new System.Windows.Forms.TextBox();
            this.button_adults_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_reservation = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_table_number = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_table_number = new System.Windows.Forms.Label();
            this.label_reservation_time = new System.Windows.Forms.Label();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mphonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtablenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataManager1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManager1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(462, 216);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(280, 370);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 40;
            this.button_reset.Text = "리셋";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_kids_del
            // 
            this.button_kids_del.Location = new System.Drawing.Point(342, 264);
            this.button_kids_del.Name = "button_kids_del";
            this.button_kids_del.Size = new System.Drawing.Size(56, 23);
            this.button_kids_del.TabIndex = 39;
            this.button_kids_del.Text = "아동-";
            this.button_kids_del.UseVisualStyleBackColor = true;
            this.button_kids_del.Click += new System.EventHandler(this.button_kids_del_Click);
            // 
            // button_kids_add
            // 
            this.button_kids_add.Location = new System.Drawing.Point(342, 235);
            this.button_kids_add.Name = "button_kids_add";
            this.button_kids_add.Size = new System.Drawing.Size(56, 23);
            this.button_kids_add.TabIndex = 38;
            this.button_kids_add.Text = "아동+";
            this.button_kids_add.UseVisualStyleBackColor = true;
            this.button_kids_add.Click += new System.EventHandler(this.button_kids_add_Click);
            // 
            // button_adults_del
            // 
            this.button_adults_del.Location = new System.Drawing.Point(280, 264);
            this.button_adults_del.Name = "button_adults_del";
            this.button_adults_del.Size = new System.Drawing.Size(56, 23);
            this.button_adults_del.TabIndex = 37;
            this.button_adults_del.Text = "성인-";
            this.button_adults_del.UseVisualStyleBackColor = true;
            this.button_adults_del.Click += new System.EventHandler(this.button_adults_del_Click);
            // 
            // label_person
            // 
            this.label_person.AutoSize = true;
            this.label_person.Location = new System.Drawing.Point(44, 305);
            this.label_person.Name = "label_person";
            this.label_person.Size = new System.Drawing.Size(53, 12);
            this.label_person.TabIndex = 36;
            this.label_person.Text = "예약자수";
            // 
            // textBox_person
            // 
            this.textBox_person.Location = new System.Drawing.Point(116, 302);
            this.textBox_person.Name = "textBox_person";
            this.textBox_person.Size = new System.Drawing.Size(122, 21);
            this.textBox_person.TabIndex = 35;
            // 
            // button_adults_add
            // 
            this.button_adults_add.Location = new System.Drawing.Point(280, 235);
            this.button_adults_add.Name = "button_adults_add";
            this.button_adults_add.Size = new System.Drawing.Size(56, 23);
            this.button_adults_add.TabIndex = 34;
            this.button_adults_add.Text = "성인+";
            this.button_adults_add.UseVisualStyleBackColor = true;
            this.button_adults_add.Click += new System.EventHandler(this.button_adults_add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(462, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "시간";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView_reservation
            // 
            this.dataGridView_reservation.AutoGenerateColumns = false;
            this.dataGridView_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNameDataGridViewTextBoxColumn,
            this.mphonenumberDataGridViewTextBoxColumn,
            this.mpersonDataGridViewTextBoxColumn,
            this.mtimeDataGridViewTextBoxColumn,
            this.mtablenumberDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn});
            this.dataGridView_reservation.DataSource = this.reservationBindingSource;
            this.dataGridView_reservation.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_reservation.Name = "dataGridView_reservation";
            this.dataGridView_reservation.RowTemplate.Height = 23;
            this.dataGridView_reservation.Size = new System.Drawing.Size(745, 197);
            this.dataGridView_reservation.TabIndex = 32;
            this.dataGridView_reservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reservation_CellContentClick);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(280, 338);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(280, 305);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 30;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_table_number
            // 
            this.textBox_table_number.Location = new System.Drawing.Point(116, 370);
            this.textBox_table_number.Name = "textBox_table_number";
            this.textBox_table_number.Size = new System.Drawing.Size(122, 21);
            this.textBox_table_number.TabIndex = 29;
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(116, 335);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(122, 21);
            this.textBox_time.TabIndex = 28;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(116, 268);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(122, 21);
            this.textBox_phone_number.TabIndex = 27;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(116, 232);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(122, 21);
            this.textBox_name.TabIndex = 26;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_table_number
            // 
            this.label_table_number.AutoSize = true;
            this.label_table_number.Location = new System.Drawing.Point(44, 373);
            this.label_table_number.Name = "label_table_number";
            this.label_table_number.Size = new System.Drawing.Size(65, 12);
            this.label_table_number.TabIndex = 25;
            this.label_table_number.Text = "테이블번호";
            // 
            // label_reservation_time
            // 
            this.label_reservation_time.AutoSize = true;
            this.label_reservation_time.Location = new System.Drawing.Point(44, 338);
            this.label_reservation_time.Name = "label_reservation_time";
            this.label_reservation_time.Size = new System.Drawing.Size(53, 12);
            this.label_reservation_time.TabIndex = 24;
            this.label_reservation_time.Text = "예약시간";
            // 
            // label_phone_number
            // 
            this.label_phone_number.AutoSize = true;
            this.label_phone_number.Location = new System.Drawing.Point(44, 271);
            this.label_phone_number.Name = "label_phone_number";
            this.label_phone_number.Size = new System.Drawing.Size(53, 12);
            this.label_phone_number.TabIndex = 23;
            this.label_phone_number.Text = "전화번호";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(44, 235);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 22;
            this.label_name.Text = "이름";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "성함";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // mphonenumberDataGridViewTextBoxColumn
            // 
            this.mphonenumberDataGridViewTextBoxColumn.DataPropertyName = "mphone_number";
            this.mphonenumberDataGridViewTextBoxColumn.HeaderText = "번호";
            this.mphonenumberDataGridViewTextBoxColumn.Name = "mphonenumberDataGridViewTextBoxColumn";
            // 
            // mpersonDataGridViewTextBoxColumn
            // 
            this.mpersonDataGridViewTextBoxColumn.DataPropertyName = "mperson";
            this.mpersonDataGridViewTextBoxColumn.HeaderText = "예약인원";
            this.mpersonDataGridViewTextBoxColumn.Name = "mpersonDataGridViewTextBoxColumn";
            // 
            // mtimeDataGridViewTextBoxColumn
            // 
            this.mtimeDataGridViewTextBoxColumn.DataPropertyName = "mtime";
            this.mtimeDataGridViewTextBoxColumn.HeaderText = "예약시간";
            this.mtimeDataGridViewTextBoxColumn.Name = "mtimeDataGridViewTextBoxColumn";
            this.mtimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // mtablenumberDataGridViewTextBoxColumn
            // 
            this.mtablenumberDataGridViewTextBoxColumn.DataPropertyName = "mtable_number";
            this.mtablenumberDataGridViewTextBoxColumn.HeaderText = "테이블번호";
            this.mtablenumberDataGridViewTextBoxColumn.Name = "mtablenumberDataGridViewTextBoxColumn";
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "예약한시간";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(winform_reservation.Reservation);
            // 
            // dataManager1BindingSource
            // 
            this.dataManager1BindingSource.DataSource = typeof(StoreManagement.DataManager);
            // 
            // ReservationUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_kids_del);
            this.Controls.Add(this.button_kids_add);
            this.Controls.Add(this.button_adults_del);
            this.Controls.Add(this.label_person);
            this.Controls.Add(this.textBox_person);
            this.Controls.Add(this.button_adults_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_reservation);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_table_number);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_table_number);
            this.Controls.Add(this.label_reservation_time);
            this.Controls.Add(this.label_phone_number);
            this.Controls.Add(this.label_name);
            this.Name = "ReservationUC";
            this.Size = new System.Drawing.Size(1207, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataManager1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_kids_del;
        private System.Windows.Forms.Button button_kids_add;
        private System.Windows.Forms.Button button_adults_del;
        private System.Windows.Forms.Label label_person;
        private System.Windows.Forms.TextBox textBox_person;
        private System.Windows.Forms.Button button_adults_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_reservation;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_table_number;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_table_number;
        private System.Windows.Forms.Label label_reservation_time;
        private System.Windows.Forms.Label label_phone_number;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource dataManager1BindingSource;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mphonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtablenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
    }
}
