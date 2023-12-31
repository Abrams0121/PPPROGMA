﻿using PPPROGMA.Classes.CRUD.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace PPPROGMA
{
    public partial class AvtorisationForm : Form
    {
        public AvtorisationForm()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text)) && !(string.IsNullOrEmpty(textBox2.Text)))
            {
                using (ServiceAvtorisation serviceAvtorisation = new ServiceAvtorisation())
                {
                    if (serviceAvtorisation.auth(textBox1.Text, textBox2.Text))
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Utils.Warning("Неправильный логин или пароль");
                    }
                } 

            } else
            {
                Utils.Warning("Введите логин и пароль");
            }
        }

        private void AvtorisationForm_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void AvtorisationForm_Activated(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
