namespace StoreManagement
{
    partial class Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_set = new System.Windows.Forms.Button();
            this.button_shutdown = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_grape = new System.Windows.Forms.Button();
            this.button_member = new System.Windows.Forms.Button();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_table = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.graphUC1 = new StoreManagement.UserControls.GraphUC();
            this.tableManagementUC1 = new StoreManagement.UserControls.TableManagementUC();
            this.customer_List1 = new StoreManagement.UserControls.Customer_ListUC();
            this.reservationUC1 = new StoreManagement.UserControls.ReservationUC();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 129);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.button_set);
            this.panel4.Controls.Add(this.button_shutdown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1217, 55);
            this.panel4.TabIndex = 3;
            // 
            // button_set
            // 
            this.button_set.FlatAppearance.BorderSize = 0;
            this.button_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set.Image = ((System.Drawing.Image)(resources.GetObject("button_set.Image")));
            this.button_set.Location = new System.Drawing.Point(1093, 1);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(51, 52);
            this.button_set.TabIndex = 1;
            this.button_set.UseVisualStyleBackColor = true;
            // 
            // button_shutdown
            // 
            this.button_shutdown.FlatAppearance.BorderSize = 0;
            this.button_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shutdown.Image = ((System.Drawing.Image)(resources.GetObject("button_shutdown.Image")));
            this.button_shutdown.Location = new System.Drawing.Point(1148, 1);
            this.button_shutdown.Name = "button_shutdown";
            this.button_shutdown.Size = new System.Drawing.Size(51, 52);
            this.button_shutdown.TabIndex = 0;
            this.button_shutdown.UseVisualStyleBackColor = true;
            this.button_shutdown.Click += new System.EventHandler(this.button_shutdown_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.button_grape);
            this.panel3.Controls.Add(this.button_member);
            this.panel3.Controls.Add(this.button_reservation);
            this.panel3.Controls.Add(this.button_table);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1217, 73);
            this.panel3.TabIndex = 3;
            // 
            // button_grape
            // 
            this.button_grape.BackColor = System.Drawing.SystemColors.Menu;
            this.button_grape.FlatAppearance.BorderSize = 0;
            this.button_grape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_grape.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grape.Location = new System.Drawing.Point(970, 0);
            this.button_grape.Name = "button_grape";
            this.button_grape.Size = new System.Drawing.Size(128, 71);
            this.button_grape.TabIndex = 4;
            this.button_grape.Text = "그래프";
            this.button_grape.UseVisualStyleBackColor = false;
            this.button_grape.Click += new System.EventHandler(this.button_grape_Click);
            // 
            // button_member
            // 
            this.button_member.BackColor = System.Drawing.SystemColors.Menu;
            this.button_member.FlatAppearance.BorderSize = 0;
            this.button_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_member.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_member.Location = new System.Drawing.Point(838, 0);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(128, 71);
            this.button_member.TabIndex = 4;
            this.button_member.Text = "회원 관리";
            this.button_member.UseVisualStyleBackColor = false;
            this.button_member.Click += new System.EventHandler(this.button_member_Click);
            // 
            // button_reservation
            // 
            this.button_reservation.BackColor = System.Drawing.SystemColors.Menu;
            this.button_reservation.FlatAppearance.BorderSize = 0;
            this.button_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reservation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reservation.Location = new System.Drawing.Point(707, 0);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(128, 71);
            this.button_reservation.TabIndex = 3;
            this.button_reservation.Text = "예약 관리";
            this.button_reservation.UseVisualStyleBackColor = false;
            this.button_reservation.Click += new System.EventHandler(this.button_reservation_Click);
            // 
            // button_table
            // 
            this.button_table.BackColor = System.Drawing.SystemColors.Menu;
            this.button_table.FlatAppearance.BorderSize = 0;
            this.button_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_table.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_table.Location = new System.Drawing.Point(576, 0);
            this.button_table.Name = "button_table";
            this.button_table.Size = new System.Drawing.Size(128, 71);
            this.button_table.TabIndex = 2;
            this.button_table.Text = "테이블 현황";
            this.button_table.UseVisualStyleBackColor = false;
            this.button_table.Click += new System.EventHandler(this.button_table_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(70, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Very Important Person";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 90);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.graphUC1);
            this.panel6.Controls.Add(this.tableManagementUC1);
            this.panel6.Controls.Add(this.customer_List1);
            this.panel6.Controls.Add(this.reservationUC1);
            this.panel6.Location = new System.Drawing.Point(0, 131);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1217, 485);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Menu;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(970, -70);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 73);
            this.button9.TabIndex = 4;
            this.button9.Text = "결제 관리";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(70, -54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Very Important Person";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(838, -70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 73);
            this.button6.TabIndex = 4;
            this.button6.Text = "회원 관리";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(12, -58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 51);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, -70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "테이블 현황";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(707, -70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 73);
            this.button5.TabIndex = 3;
            this.button5.Text = "예약 관리";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // graphUC1
            // 
            this.graphUC1.Location = new System.Drawing.Point(3, 3);
            this.graphUC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.graphUC1.Name = "graphUC1";
            this.graphUC1.Size = new System.Drawing.Size(1211, 467);
            this.graphUC1.TabIndex = 3;
            this.graphUC1.Visible = false;
            // 
            // tableManagementUC1
            // 
            this.tableManagementUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableManagementUC1.Location = new System.Drawing.Point(0, 0);
            this.tableManagementUC1.Name = "tableManagementUC1";
            this.tableManagementUC1.Size = new System.Drawing.Size(1217, 485);
            this.tableManagementUC1.TabIndex = 2;
            // 
            // customer_List1
            // 
            this.customer_List1.BackColor = System.Drawing.Color.White;
            this.customer_List1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer_List1.Location = new System.Drawing.Point(0, 0);
            this.customer_List1.Name = "customer_List1";
            this.customer_List1.Size = new System.Drawing.Size(1217, 485);
            this.customer_List1.TabIndex = 1;
            this.customer_List1.Visible = false;
            // 
            // reservationUC1
            // 
            this.reservationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationUC1.Location = new System.Drawing.Point(0, 0);
            this.reservationUC1.Name = "reservationUC1";
            this.reservationUC1.Size = new System.Drawing.Size(1217, 485);
            this.reservationUC1.TabIndex = 0;
            this.reservationUC1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 677);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "VIP";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_table;
        private System.Windows.Forms.Button button_grape;
        private System.Windows.Forms.Button button_member;
        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_shutdown;
        private UserControls.TableManagementUC tableManagementUC1;
        private UserControls.Customer_ListUC customer_List1;
        private UserControls.ReservationUC reservationUC1;
        private UserControls.GraphUC graphUC1;
    }
}

