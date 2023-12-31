﻿using Org.BouncyCastle.Crypto;
using PPPROGMA;
using PPPROGMA.Classes.CRUD;
using PPPROGMA.Classes.CRUD.Service;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelectListForm<T> : Form
    {
        public T table { get; set; } 

        public int id { get; set; }

        public bool changed = false;

        public int count;
        List<T> list { get; set; }

        public SelectListForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int res;
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["id"].Value.ToString(), out res))
            {
                Utils.Error("Ошибка конвертации");
                return;
            }
            id = res;
            count = Convert.ToInt32(numericUpDown1.Value);
            changed = true;
            Close();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        internal class ListHolder
        {
        }

        private void Constructor()
        {
            numericUpDown1.Visible = false;
            label2.Visible = false;
            using (Read listView = new Read())
            {


                switch (typeof(T).Name)
                {
                    case "Transport":
                        ListHolder lists = new ListHolder();
                        dataGridView1.Columns["ID"].DataPropertyName = "idTransport";
                        dataGridView1.Columns["ColName"].DataPropertyName = "Transport_name";
                        dataGridView1.Columns["Price"].DataPropertyName = "Transport_price";
                        dataGridView1.DataSource = Read.UpdateList<Transport>();
                        break;
                    case "Service":
                        dataGridView1.Columns["ID"].DataPropertyName = "idServices";
                        dataGridView1.Columns["ColName"].DataPropertyName = "Service_name";
                        dataGridView1.Columns["Price"].DataPropertyName = "Service_cost";
                        dataGridView1.DataSource = Read.UpdateList<Service>();
                        break;
                    case "General_service":
                        dataGridView1.Columns["ID"].DataPropertyName = "idgeneral_Service";
                        dataGridView1.Columns["ColName"].DataPropertyName = "general_Service_name";
                        dataGridView1.Columns["Price"].DataPropertyName = "general_Service_price";
                        dataGridView1.DataSource = Read.UpdateList<General_service>();
                        numericUpDown1.Visible = true;
                        label2.Visible = true;
                        break;
                    case "Combinetion_of_tours":
                        dataGridView1.Columns["ID"].DataPropertyName = "idcombinetion_of_tours";
                        dataGridView1.Columns["ColName"].DataPropertyName = "combinetion_of_tours_name";
                        dataGridView1.Columns["Price"].DataPropertyName = "combinetion_of_tours_price";
                        dataGridView1.DataSource = Read.UpdateList<Combinetion_of_tours>();
                        
                        break;
                    case "Accommodation":
                        dataGridView1.Columns["ID"].DataPropertyName = "idAccommodation";
                        dataGridView1.Columns["ColName"].DataPropertyName = "Accommodation_name";
                        dataGridView1.Columns["Price"].DataPropertyName = "Price_for_one_person";
                        dataGridView1.DataSource = Read.UpdateList<Accommodation>();
                        break;
                    default:
                        break;
                }
            }
        }

        private void SelectListForm_Load(object sender, EventArgs e)
        {
            Constructor();
        }
    }
}
