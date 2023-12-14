using PPPROGMA.Classes.Models;
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

namespace WindowsFormsApp1
{
    public partial class ServiceEditForm : Form
    {
        bool changing = false;

        int id;

        Service service;

        public ServiceEditForm()
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

        private void AddButton_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Utils.Warning("Введите значения");
                return;
            }

            CrudService DBWORK = new CrudService();

            if (!changing)
            {
                service = new Service()
                {
                    Service_name = textBox1.Text,
                    Service_cost = Utils.StringToDecimal(maskedTextBox1.Text),

                };

                if (DBWORK.setName(textBox1.Text, service))
                {
                    DBWORK.Insert(service);
                    Close();
                    return;
                }
            }
            else
            {
                service = DBWORK.ForUpdateServicet(id);
                if (DBWORK.setName(textBox1.Text, service))
                {
                    service.Service_name = textBox1.Text;
                    service.Service_cost = Utils.StringToDecimal(maskedTextBox1.Text);
                    DBWORK.Update();
                    Close();
                    return;
                }
            }
        }

        private void ServiceEditForm_Load(object sender, EventArgs e)
        {
            service = CrudService.UpdateService(id);

            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = service.Service_name;
                maskedTextBox1.Text = Utils.DecimalToString(service.Service_cost);
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
        }
    }
}
