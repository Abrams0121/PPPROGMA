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
    public partial class GeneralServiceEditForm : Form
    {
        public bool changing = false;

        public int id;

        General_service general_Service;

        public GeneralServiceEditForm()
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

            ServiceGeneralServices DBWORK = new ServiceGeneralServices();

            if (!changing)
            {
                general_Service = new General_service()
                {
                    general_Service_name = textBox1.Text,
                    general_Service_price = Utils.StringToDecimal(maskedTextBox1.Text),

                };

                if (DBWORK.setName(textBox1.Text, general_Service))
                {
                    DBWORK.Insert(general_Service);
                    Close();
                    return;
                }
            }
            else
            {
                general_Service = DBWORK.ForUpdateTour(id);
                if (DBWORK.setName(textBox1.Text, general_Service))
                {
                    general_Service.general_Service_name = textBox1.Text;
                    general_Service.general_Service_price = Utils.StringToDecimal(maskedTextBox1.Text);
                    DBWORK.Update();
                    Close();
                    return;
                }
            }
        }

        private void GeneralServiceEditForm_Load(object sender, EventArgs e)
        {
            general_Service = ServiceGeneralServices.UpdateGeneral_service(id);

            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = general_Service.general_Service_name;
                maskedTextBox1.Text = Utils.DecimalToString(general_Service.general_Service_price);
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
        }
    }
}
