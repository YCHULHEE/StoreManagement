namespace StoreManagement.UserControls
{
    partial class Customer_List
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Cus_Search = new System.Windows.Forms.TabPage();
            this.dataGridView_Customer_Search = new System.Windows.Forms.DataGridView();
            this.label_Search_Count = new System.Windows.Forms.Label();
            this.label_Search_Main = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.Tab_Cus_Manage = new System.Windows.Forms.TabPage();
            this.dataGridView_Customer_manage = new System.Windows.Forms.DataGridView();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRegdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Manage_Delete = new System.Windows.Forms.Button();
            this.textBox_Birthday = new System.Windows.Forms.TextBox();
            this.textBox_Enterdate = new System.Windows.Forms.TextBox();
            this.button_Manage_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Manage_Modify = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Manage_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Phonenum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Sex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Changes_Recode = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Tab_Cus_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer_Search)).BeginInit();
            this.Tab_Cus_Manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer_manage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Cus_Search);
            this.tabControl1.Controls.Add(this.Tab_Cus_Manage);
            this.tabControl1.Location = new System.Drawing.Point(18, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 477);
            this.tabControl1.TabIndex = 2;
            // 
            // Tab_Cus_Search
            // 
            this.Tab_Cus_Search.Controls.Add(this.dataGridView_Customer_Search);
            this.Tab_Cus_Search.Controls.Add(this.label_Search_Count);
            this.Tab_Cus_Search.Controls.Add(this.label_Search_Main);
            this.Tab_Cus_Search.Controls.Add(this.panel1);
            this.Tab_Cus_Search.Controls.Add(this.button_Search);
            this.Tab_Cus_Search.Controls.Add(this.textBox_Search);
            this.Tab_Cus_Search.Controls.Add(this.label_Search);
            this.Tab_Cus_Search.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cus_Search.Name = "Tab_Cus_Search";
            this.Tab_Cus_Search.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cus_Search.Size = new System.Drawing.Size(972, 451);
            this.Tab_Cus_Search.TabIndex = 0;
            this.Tab_Cus_Search.Text = "회원 조회";
            this.Tab_Cus_Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Customer_Search
            // 
            this.dataGridView_Customer_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer_Search.Location = new System.Drawing.Point(33, 137);
            this.dataGridView_Customer_Search.Name = "dataGridView_Customer_Search";
            this.dataGridView_Customer_Search.RowTemplate.Height = 23;
            this.dataGridView_Customer_Search.Size = new System.Drawing.Size(665, 151);
            this.dataGridView_Customer_Search.TabIndex = 6;
            // 
            // label_Search_Count
            // 
            this.label_Search_Count.AutoSize = true;
            this.label_Search_Count.Location = new System.Drawing.Point(745, 137);
            this.label_Search_Count.Name = "label_Search_Count";
            this.label_Search_Count.Size = new System.Drawing.Size(85, 12);
            this.label_Search_Count.TabIndex = 5;
            this.label_Search_Count.Text = "검색 건수 출력";
            // 
            // label_Search_Main
            // 
            this.label_Search_Main.AutoSize = true;
            this.label_Search_Main.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Search_Main.Location = new System.Drawing.Point(15, 14);
            this.label_Search_Main.Name = "label_Search_Main";
            this.label_Search_Main.Size = new System.Drawing.Size(128, 17);
            this.label_Search_Main.TabIndex = 4;
            this.label_Search_Main.Text = "회원 등록 검색";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 10);
            this.panel1.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(250, 92);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "검색";
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(90, 92);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(154, 21);
            this.textBox_Search.TabIndex = 1;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(31, 95);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(53, 12);
            this.label_Search.TabIndex = 0;
            this.label_Search.Text = "검색대상";
            // 
            // Tab_Cus_Manage
            // 
            this.Tab_Cus_Manage.Controls.Add(this.panel4);
            this.Tab_Cus_Manage.Controls.Add(this.dataGridView_Customer_manage);
            this.Tab_Cus_Manage.Controls.Add(this.panel2);
            this.Tab_Cus_Manage.Controls.Add(this.panel3);
            this.Tab_Cus_Manage.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cus_Manage.Name = "Tab_Cus_Manage";
            this.Tab_Cus_Manage.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cus_Manage.Size = new System.Drawing.Size(972, 451);
            this.Tab_Cus_Manage.TabIndex = 1;
            this.Tab_Cus_Manage.Text = "회원 관리";
            this.Tab_Cus_Manage.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Customer_manage
            // 
            this.dataGridView_Customer_manage.AutoGenerateColumns = false;
            this.dataGridView_Customer_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customer_manage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNameDataGridViewTextBoxColumn,
            this.mSexDataGridViewTextBoxColumn,
            this.mPhoneNumDataGridViewTextBoxColumn,
            this.mBirthdayDataGridViewTextBoxColumn,
            this.mRegdateDataGridViewTextBoxColumn});
            this.dataGridView_Customer_manage.DataSource = this.customerBindingSource1;
            this.dataGridView_Customer_manage.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Customer_manage.Name = "dataGridView_Customer_manage";
            this.dataGridView_Customer_manage.RowTemplate.Height = 23;
            this.dataGridView_Customer_manage.Size = new System.Drawing.Size(970, 176);
            this.dataGridView_Customer_manage.TabIndex = 0;
            this.dataGridView_Customer_manage.CurrentCellChanged += new System.EventHandler(this.dataGridView_Customer_manage_CurrentCellChanged);
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "m_Name";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "성명";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            // 
            // mSexDataGridViewTextBoxColumn
            // 
            this.mSexDataGridViewTextBoxColumn.DataPropertyName = "m_Sex";
            this.mSexDataGridViewTextBoxColumn.HeaderText = "성별";
            this.mSexDataGridViewTextBoxColumn.Name = "mSexDataGridViewTextBoxColumn";
            // 
            // mPhoneNumDataGridViewTextBoxColumn
            // 
            this.mPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "m_PhoneNum";
            this.mPhoneNumDataGridViewTextBoxColumn.HeaderText = "연락처";
            this.mPhoneNumDataGridViewTextBoxColumn.Name = "mPhoneNumDataGridViewTextBoxColumn";
            // 
            // mBirthdayDataGridViewTextBoxColumn
            // 
            this.mBirthdayDataGridViewTextBoxColumn.DataPropertyName = "m_Birthday";
            this.mBirthdayDataGridViewTextBoxColumn.HeaderText = "생일";
            this.mBirthdayDataGridViewTextBoxColumn.Name = "mBirthdayDataGridViewTextBoxColumn";
            // 
            // mRegdateDataGridViewTextBoxColumn
            // 
            this.mRegdateDataGridViewTextBoxColumn.DataPropertyName = "m_Regdate";
            this.mRegdateDataGridViewTextBoxColumn.HeaderText = "등록 일시";
            this.mRegdateDataGridViewTextBoxColumn.Name = "mRegdateDataGridViewTextBoxColumn";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(StoreManagement.Customer);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button_Manage_Delete);
            this.panel2.Controls.Add(this.button_Manage_Search);
            this.panel2.Controls.Add(this.button_Manage_Modify);
            this.panel2.Controls.Add(this.button_Manage_Add);
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 108);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "관리 기능";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "회원 정보 입력";
            // 
            // button_Manage_Delete
            // 
            this.button_Manage_Delete.Location = new System.Drawing.Point(123, 64);
            this.button_Manage_Delete.Name = "button_Manage_Delete";
            this.button_Manage_Delete.Size = new System.Drawing.Size(80, 30);
            this.button_Manage_Delete.TabIndex = 2;
            this.button_Manage_Delete.Text = "회원 삭제";
            this.button_Manage_Delete.UseVisualStyleBackColor = true;
            this.button_Manage_Delete.Click += new System.EventHandler(this.button_Manage_Delete_Click);
            // 
            // textBox_Birthday
            // 
            this.textBox_Birthday.Location = new System.Drawing.Point(359, 24);
            this.textBox_Birthday.Name = "textBox_Birthday";
            this.textBox_Birthday.Size = new System.Drawing.Size(100, 21);
            this.textBox_Birthday.TabIndex = 14;
            // 
            // textBox_Enterdate
            // 
            this.textBox_Enterdate.Location = new System.Drawing.Point(359, 51);
            this.textBox_Enterdate.Name = "textBox_Enterdate";
            this.textBox_Enterdate.Size = new System.Drawing.Size(100, 21);
            this.textBox_Enterdate.TabIndex = 16;
            // 
            // button_Manage_Search
            // 
            this.button_Manage_Search.Location = new System.Drawing.Point(265, 64);
            this.button_Manage_Search.Name = "button_Manage_Search";
            this.button_Manage_Search.Size = new System.Drawing.Size(80, 30);
            this.button_Manage_Search.TabIndex = 4;
            this.button_Manage_Search.Text = "회원 조회";
            this.button_Manage_Search.UseVisualStyleBackColor = true;
            this.button_Manage_Search.Click += new System.EventHandler(this.button_Manage_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름";
            // 
            // button_Manage_Modify
            // 
            this.button_Manage_Modify.Location = new System.Drawing.Point(265, 21);
            this.button_Manage_Modify.Name = "button_Manage_Modify";
            this.button_Manage_Modify.Size = new System.Drawing.Size(80, 30);
            this.button_Manage_Modify.TabIndex = 3;
            this.button_Manage_Modify.Text = "회원 수정";
            this.button_Manage_Modify.UseVisualStyleBackColor = true;
            this.button_Manage_Modify.Click += new System.EventHandler(this.button_Manage_Modify_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(172, 26);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 10;
            // 
            // button_Manage_Add
            // 
            this.button_Manage_Add.Location = new System.Drawing.Point(123, 19);
            this.button_Manage_Add.Name = "button_Manage_Add";
            this.button_Manage_Add.Size = new System.Drawing.Size(80, 30);
            this.button_Manage_Add.TabIndex = 1;
            this.button_Manage_Add.Text = "회원 추가";
            this.button_Manage_Add.UseVisualStyleBackColor = true;
            this.button_Manage_Add.Click += new System.EventHandler(this.button_Manage_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "등록 일시";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "성별";
            // 
            // textBox_Phonenum
            // 
            this.textBox_Phonenum.Location = new System.Drawing.Point(172, 80);
            this.textBox_Phonenum.Name = "textBox_Phonenum";
            this.textBox_Phonenum.Size = new System.Drawing.Size(100, 21);
            this.textBox_Phonenum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "연락처";
            // 
            // textBox_Sex
            // 
            this.textBox_Sex.Location = new System.Drawing.Point(172, 53);
            this.textBox_Sex.Name = "textBox_Sex";
            this.textBox_Sex.Size = new System.Drawing.Size(100, 21);
            this.textBox_Sex.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "생일";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.listBox_Changes_Recode);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(-4, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 173);
            this.panel3.TabIndex = 20;
            // 
            // listBox_Changes_Recode
            // 
            this.listBox_Changes_Recode.FormattingEnabled = true;
            this.listBox_Changes_Recode.ItemHeight = 12;
            this.listBox_Changes_Recode.Location = new System.Drawing.Point(23, 30);
            this.listBox_Changes_Recode.Name = "listBox_Changes_Recode";
            this.listBox_Changes_Recode.Size = new System.Drawing.Size(925, 112);
            this.listBox_Changes_Recode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "회원 관리 이력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "회원 관리 System";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox_Name);
            this.panel4.Controls.Add(this.textBox_Birthday);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_Enterdate);
            this.panel4.Controls.Add(this.textBox_Phonenum);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_Sex);
            this.panel4.Location = new System.Drawing.Point(485, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 108);
            this.panel4.TabIndex = 21;
            // 
            // Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer_List";
            this.Size = new System.Drawing.Size(1025, 525);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Cus_Search.ResumeLayout(false);
            this.Tab_Cus_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer_Search)).EndInit();
            this.Tab_Cus_Manage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customer_manage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Cus_Search;
        private System.Windows.Forms.TabPage Tab_Cus_Manage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Search_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.DataGridView dataGridView_Customer_manage;
        private System.Windows.Forms.Label label_Search_Count;
        private System.Windows.Forms.Button button_Manage_Search;
        private System.Windows.Forms.Button button_Manage_Modify;
        private System.Windows.Forms.Button button_Manage_Delete;
        private System.Windows.Forms.Button button_Manage_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Birthday;
        private System.Windows.Forms.TextBox textBox_Phonenum;
        private System.Windows.Forms.TextBox textBox_Sex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Enterdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Customer_Search;
        private System.Windows.Forms.ListBox listBox_Changes_Recode;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRegdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
    }
}
