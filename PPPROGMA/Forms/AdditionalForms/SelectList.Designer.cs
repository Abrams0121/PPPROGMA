
namespace WindowsFormsApp1
{
    partial class SelectListForm<T>
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.pnlBorder.Size = new System.Drawing.Size(715, 23);
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
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавление";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(671, 0);
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
            this.btnMinimize.Location = new System.Drawing.Point(693, 0);
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
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(489, 491);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 29);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(625, 490);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(78, 29);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Назад";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColName,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 491);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Название";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 200;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(471, 350);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Колличество :";
            // 
            // SelectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprav_table_form";
            this.Load += new System.EventHandler(this.SelectListForm_Load);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnMinimize;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

