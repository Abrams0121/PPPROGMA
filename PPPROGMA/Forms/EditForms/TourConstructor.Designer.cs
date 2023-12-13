
namespace WindowsFormsApp1
{
    partial class TourConstructorForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transportDataGridView = new System.Windows.Forms.DataGridView();
            this.TransportIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.ServiceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.GeneralServiceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accomodationDataGridView = new System.Windows.Forms.DataGridView();
            this.AccomodationIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.FoodIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tourDaysDataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.combinedToursDataGridView = new System.Windows.Forms.DataGridView();
            this.ComToursIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalServicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accomodationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDaysDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedToursDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBorder.Controls.Add(this.mainLabel);
            this.pnlBorder.Controls.Add(this.BtnClose);
            this.pnlBorder.Controls.Add(this.btnMinimize);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1298, 16);
            this.pnlBorder.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainLabel.Location = new System.Drawing.Point(0, 0);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(117, 13);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Название таблицы";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Location = new System.Drawing.Point(1262, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(18, 16);
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
            this.btnMinimize.Location = new System.Drawing.Point(1280, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 16);
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
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(1188, 661);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(99, 33);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "Назад";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1090, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1006, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название тура";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1006, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 21);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(908, 100);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дни тура";
            // 
            // transportDataGridView
            // 
            this.transportDataGridView.AllowUserToAddRows = false;
            this.transportDataGridView.AllowUserToDeleteRows = false;
            this.transportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransportIndex,
            this.Column5,
            this.Column6});
            this.transportDataGridView.Location = new System.Drawing.Point(38, 375);
            this.transportDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transportDataGridView.Name = "transportDataGridView";
            this.transportDataGridView.ReadOnly = true;
            this.transportDataGridView.Size = new System.Drawing.Size(245, 161);
            this.transportDataGridView.TabIndex = 16;
            // 
            // TransportIndex
            // 
            this.TransportIndex.HeaderText = "Column5";
            this.TransportIndex.Name = "TransportIndex";
            this.TransportIndex.ReadOnly = true;
            this.TransportIndex.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Название транспорта";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Цена транспорта";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceIndex,
            this.Column7,
            this.Column8});
            this.serviceDataGridView.Location = new System.Drawing.Point(417, 375);
            this.serviceDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.Size = new System.Drawing.Size(253, 161);
            this.serviceDataGridView.TabIndex = 17;
            // 
            // ServiceIndex
            // 
            this.ServiceIndex.HeaderText = "Column7";
            this.ServiceIndex.Name = "ServiceIndex";
            this.ServiceIndex.ReadOnly = true;
            this.ServiceIndex.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Название услуги";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Цена услуги";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // generalServicesDataGridView
            // 
            this.generalServicesDataGridView.AllowUserToAddRows = false;
            this.generalServicesDataGridView.AllowUserToDeleteRows = false;
            this.generalServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GeneralServiceIndex,
            this.Column9,
            this.Column10});
            this.generalServicesDataGridView.Location = new System.Drawing.Point(846, 375);
            this.generalServicesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalServicesDataGridView.Name = "generalServicesDataGridView";
            this.generalServicesDataGridView.ReadOnly = true;
            this.generalServicesDataGridView.Size = new System.Drawing.Size(250, 161);
            this.generalServicesDataGridView.TabIndex = 18;
            // 
            // GeneralServiceIndex
            // 
            this.GeneralServiceIndex.HeaderText = "Column9";
            this.GeneralServiceIndex.Name = "GeneralServiceIndex";
            this.GeneralServiceIndex.ReadOnly = true;
            this.GeneralServiceIndex.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Название общей услуги";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Цена общей услуги";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // accomodationDataGridView
            // 
            this.accomodationDataGridView.AllowUserToAddRows = false;
            this.accomodationDataGridView.AllowUserToDeleteRows = false;
            this.accomodationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accomodationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccomodationIndex,
            this.Column3,
            this.Column4});
            this.accomodationDataGridView.Location = new System.Drawing.Point(316, 188);
            this.accomodationDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accomodationDataGridView.Name = "accomodationDataGridView";
            this.accomodationDataGridView.ReadOnly = true;
            this.accomodationDataGridView.Size = new System.Drawing.Size(444, 88);
            this.accomodationDataGridView.TabIndex = 19;
            // 
            // AccomodationIndex
            // 
            this.AccomodationIndex.HeaderText = "Column3";
            this.AccomodationIndex.Name = "AccomodationIndex";
            this.AccomodationIndex.ReadOnly = true;
            this.AccomodationIndex.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Название отеля";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена за одну ночь на человека";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AllowUserToAddRows = false;
            this.foodDataGridView.AllowUserToDeleteRows = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodIndex,
            this.Column2});
            this.foodDataGridView.Location = new System.Drawing.Point(30, 188);
            this.foodDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.ReadOnly = true;
            this.foodDataGridView.Size = new System.Drawing.Size(155, 122);
            this.foodDataGridView.TabIndex = 20;
            // 
            // FoodIndex
            // 
            this.FoodIndex.HeaderText = "Column2";
            this.FoodIndex.Name = "FoodIndex";
            this.FoodIndex.ReadOnly = true;
            this.FoodIndex.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 24);
            this.button2.TabIndex = 21;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 216);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 24);
            this.button3.TabIndex = 22;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 375);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 24);
            this.button4.TabIndex = 23;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 404);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 24);
            this.button5.TabIndex = 24;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(783, 188);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 24);
            this.button6.TabIndex = 25;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(783, 216);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 24);
            this.button7.TabIndex = 26;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(676, 375);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 24);
            this.button8.TabIndex = 27;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(676, 404);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 24);
            this.button9.TabIndex = 28;
            this.button9.Text = "Удалить";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1131, 375);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 24);
            this.button10.TabIndex = 29;
            this.button10.Text = "Добавить";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1131, 404);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 24);
            this.button11.TabIndex = 30;
            this.button11.Text = "Удалить";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // tourDaysDataGridView
            // 
            this.tourDaysDataGridView.AllowUserToAddRows = false;
            this.tourDaysDataGridView.AllowUserToDeleteRows = false;
            this.tourDaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourDaysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Column1});
            this.tourDaysDataGridView.Location = new System.Drawing.Point(31, 53);
            this.tourDaysDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tourDaysDataGridView.Name = "tourDaysDataGridView";
            this.tourDaysDataGridView.ReadOnly = true;
            this.tourDaysDataGridView.Size = new System.Drawing.Size(148, 82);
            this.tourDaysDataGridView.TabIndex = 31;
            // 
            // Index
            // 
            this.Index.HeaderText = "ID";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "День";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(199, 53);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 24);
            this.button12.TabIndex = 32;
            this.button12.Text = "Добавить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(199, 81);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 24);
            this.button13.TabIndex = 33;
            this.button13.Text = "Удалить";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Проживание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Питание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Транспорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Услуги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(843, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Общие услуги";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Сборные туры";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(309, 597);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 26);
            this.button14.TabIndex = 41;
            this.button14.Text = "Удалить";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(309, 568);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 26);
            this.button15.TabIndex = 40;
            this.button15.Text = "Добавить";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // combinedToursDataGridView
            // 
            this.combinedToursDataGridView.AllowUserToAddRows = false;
            this.combinedToursDataGridView.AllowUserToDeleteRows = false;
            this.combinedToursDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combinedToursDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComToursIndex,
            this.Column11,
            this.Column12});
            this.combinedToursDataGridView.Location = new System.Drawing.Point(39, 568);
            this.combinedToursDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combinedToursDataGridView.Name = "combinedToursDataGridView";
            this.combinedToursDataGridView.ReadOnly = true;
            this.combinedToursDataGridView.Size = new System.Drawing.Size(244, 161);
            this.combinedToursDataGridView.TabIndex = 39;
            // 
            // ComToursIndex
            // 
            this.ComToursIndex.HeaderText = "Column11";
            this.ComToursIndex.Name = "ComToursIndex";
            this.ComToursIndex.ReadOnly = true;
            this.ComToursIndex.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Название сборного тура";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Цена";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // TourConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1298, 705);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.combinedToursDataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.tourDaysDataGridView);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.foodDataGridView);
            this.Controls.Add(this.accomodationDataGridView);
            this.Controls.Add(this.generalServicesDataGridView);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.transportDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.pnlBorder);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TourConstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprav_table_form";
            this.Load += new System.EventHandler(this.TourConstructorForm_Load);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalServicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accomodationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDaysDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedToursDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnMinimize;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transportDataGridView;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.DataGridView generalServicesDataGridView;
        private System.Windows.Forms.DataGridView accomodationDataGridView;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView tourDaysDataGridView;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView combinedToursDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccomodationIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralServiceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComToursIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

