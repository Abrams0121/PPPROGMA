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
using PPPROGMA.Classes.CRUD.Service;

namespace WindowsFormsApp1
{
    public partial class AccomodationEditForm : Form
    {
        public bool changing;

        public int id;

        Accommodation accommodation;


        public AccomodationEditForm()
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

            ServiceAccomodation DBWORK = new ServiceAccomodation();

            if (!changing)
            {
                accommodation = new Accommodation()
                {
                    Accommodation_name = textBox1.Text,
                    Price_for_one_person = Utils.StringToDecimal(maskedTextBox1.Text),

                };

                if (DBWORK.setName(textBox1.Text, accommodation))
                {
                    DBWORK.Insert(accommodation);
                    Close();
                    return;
                }
            }
            else
            {
                accommodation = DBWORK.ForUpdateAccommodation(id);
                if (DBWORK.setName(textBox1.Text, accommodation))
                {
                    accommodation.Accommodation_name = textBox1.Text;
                    accommodation.Price_for_one_person = Utils.StringToDecimal(maskedTextBox1.Text);
                    DBWORK.Update();
                    Close();
                    return;
                }
            }
        }

        private void AccomodationEditForm_Load(object sender, EventArgs e)
        {
            accommodation = ServiceAccomodation.UpdateAccommodation(id);

            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = accommodation.Accommodation_name;
                maskedTextBox1.Text = Utils.DecimalToString(accommodation.Price_for_one_person);
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
        }
    }
}
