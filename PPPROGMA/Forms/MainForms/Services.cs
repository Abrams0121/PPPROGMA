﻿using PPPROGMA.Classes.Models;
using PPPROGMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1
{
    public partial class ServiceTable : Form
    {

        List<Service> services;
        public ServiceTable()
        {
            dataGridView2.AutoGenerateColumns = false;
            InitializeComponent();
            services = CrudService.UpdateService();
            dataGridView2.DataSource = services;
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

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var service = CrudService.UpdateService(int.Parse(dataGridView2.CurrentRow.Cells["id"].Value.ToString()));
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CrudService DBWORk = new CrudService())
                {
                    DBWORk.delete(service);
                }
                services = CrudService.UpdateService();
                dataGridView2.DataSource = services;
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                
                services = CrudService.SearchForSpecific(textBox1.Text);
                dataGridView2.DataSource = services;
            }else
            {
                services = CrudService.UpdateService();
                dataGridView2.DataSource = services;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            services = CrudService.UpdateService();
            dataGridView2.DataSource = services;
        }
    }
}
