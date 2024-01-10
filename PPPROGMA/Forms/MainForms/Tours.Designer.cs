
namespace WindowsFormsApp1
{
    partial class ToursTableForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBorder.Controls.Add(this.label1);
            this.pnlBorder.Controls.Add(this.BtnClose);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1370, 23);
            this.pnlBorder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Туры";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(1326, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(22, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "_";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Location = new System.Drawing.Point(1348, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 23);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "X";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column6,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 561);
            this.dataGridView2.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "idTours";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tour_Name";
            this.Column2.HeaderText = "Название тура";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tourist_Count";
            this.Column6.HeaderText = "Колличество туристов";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tour_start_date";
            this.Column1.HeaderText = "Дата старта";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tour_Cost_No_Marja";
            this.Column3.HeaderText = "Стоимость без маржи";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tour_Cost_marja";
            this.Column4.HeaderText = "Стоимость с маржей";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tour_cost_For_one_person";
            this.Column5.HeaderText = "Стоимость для одного туриста";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tour_Profit";
            this.Column7.HeaderText = "Профит с тура";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(790, 48);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 26);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(790, 90);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(98, 26);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(790, 131);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 26);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(1317, 544);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(78, 29);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Назад";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1128, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1128, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1240, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отобрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1128, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1045, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "По :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1125, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Отбор по дате";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1108, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Составить расписание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1105, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Отбор для документа по дате";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1045, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "По :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1045, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "C :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1128, 362);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(1128, 315);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker4.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1128, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 29);
            this.button4.TabIndex = 20;
            this.button4.Text = "Сформировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1087, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Отбор со стоимостью выше :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1140, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 29);
            this.button5.TabIndex = 23;
            this.button5.Text = "Сформировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1108, 458);
            this.maskedTextBox1.Mask = "$9,999,000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(210, 26);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // ToursTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 584);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToursTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprav_table_form";
            this.Load += new System.EventHandler(this.ToursTableForm_Load);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnMinimize;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

