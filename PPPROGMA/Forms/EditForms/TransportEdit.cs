using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class TransportEditForm : Form
    {
        public bool changing = false;


        public int id;

        List<Sprav_transport_type> sprav_Transport_Types => Read.TransportTypeUpdate();

        Transport transport;

        public TransportEditForm()
        {
            InitializeComponent();
            transport = Program.BD.transports.SingleOrDefault(x => x.idTransport == id);
            comboBox1.DataSource = sprav_Transport_Types;
            comboBox1.DisplayMember = "Sprav_Transport_typecol";
            comboBox1.ValueMember = "idSprav_Transport_type";

            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = transport.Transport_name;
                maskedTextBox1.Text = Utils.DecimalToString(transport.Transport_price);
                comboBox1.SelectedValue = transport.idSprav_Transport_type;
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
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
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Utils.Warning("Введите значения");
                return;
            }

            ServiceTransport BDWORK = new ServiceTransport();

            if (!changing)
            {
                transport = new Transport()
                {
                    Transport_name = textBox1.Text,
                    Transport_price = Utils.StringToDecimal(maskedTextBox1.Text),
                    idSprav_Transport_type = int.Parse(comboBox1.SelectedValue.ToString())
                    
                };

                if (BDWORK.setName(textBox1.Text, transport))
                {
                    BDWORK.Insert(transport);
                    Close();
                    return;
                }
            }
            else
            {
                if (BDWORK.setName(textBox1.Text, transport))
                {
                    transport.Transport_name = textBox1.Text;
                    transport.Transport_price = Utils.StringToDecimal(maskedTextBox1.Text);
                    transport.idSprav_Transport_type = int.Parse(comboBox1.SelectedValue.ToString());
                    BDWORK.Update();
                    Close();
                    return;
                }
            }
        }
    }
}
