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
            InitializeComponent();
            services = Program.BD.services.ToList();
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
            var service = Program.BD.services.FirstOrDefault(x => x.idServices == int.Parse(dataGridView2.CurrentRow.Cells["id"].Value.ToString()));
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                service.delete();
                services = Program.BD.services.ToList();
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                services.Clear();
                services = Program.BD.services.Where(x => EF.Functions.Like(x.Service_name,textBox1.Text)).ToList();
            }else
            {
                services.Clear();
                services = Program.BD.services.ToList();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            services.Clear();
            services = Program.BD.services.ToList();
        }
    }
}
