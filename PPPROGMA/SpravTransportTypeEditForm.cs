﻿using PPPROGMA.Classes.CRUD.Service;
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

namespace PPPROGMA
{
    public partial class SpravTransportTypeEditForm : Form
    {
        public bool changing = false;

        public int index;

        Sprav_transport_type type;
        public SpravTransportTypeEditForm()
        {   
            InitializeComponent();
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextCheck.KeyCheck(e);
            TextCheck.KeyCheckForNum(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Utils.Warning("Введите значения");
                return;
            }

            using (Service_sprav_transport_type BDWORK = new Service_sprav_transport_type())
            {
                if (!changing)
                {
                    type = new Sprav_transport_type()
                    {
                        Sprav_Transport_typecol = textBox1.Text
                    };

                    if (BDWORK.setName(textBox1.Text,"_", type))
                    {
                        BDWORK.Insert(type);
                        Close();
                        return;
                    }
                }
                else
                {
                    Sprav_transport_type type = BDWORK.ForUpdateTransport(index);
                    if (BDWORK.setName(textBox1.Text, type))
                    {
                        type.Sprav_Transport_typecol = textBox1.Text;
                        BDWORK.Update();
                        Close();
                        return;
                    }
                }
            }

        }

        private void SpravTransportTypeEditForm_Load(object sender, EventArgs e)
        {
            type = Service_sprav_transport_type.UpdateTransport(index);
            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = type.Sprav_Transport_typecol;
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
        }
    }
}
