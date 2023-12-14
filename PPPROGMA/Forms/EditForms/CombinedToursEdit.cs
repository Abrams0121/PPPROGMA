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
    public partial class CombinedToursEditForm : Form
    {
        public bool changing = false;

        public int id;

        Combinetion_of_tours combinetion_Of_Tours;

        public CombinedToursEditForm()
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

            Service_Combination_Of_Tours DBWORK = new Service_Combination_Of_Tours();

            if (!changing)
            {
                combinetion_Of_Tours = new Combinetion_of_tours()
                {
                    combinetion_of_tours_name = textBox1.Text,
                    combinetion_of_tours_price = Utils.StringToDecimal(maskedTextBox1.Text),

                };

                if (DBWORK.setName(textBox1.Text, combinetion_Of_Tours))
                {
                    DBWORK.Insert(combinetion_Of_Tours);
                    Close();
                    return;
                }
            }
            else
            {
                combinetion_Of_Tours = DBWORK.ForUpdateTransport(id);
                if (DBWORK.setName(textBox1.Text, combinetion_Of_Tours))
                {
                    combinetion_Of_Tours.combinetion_of_tours_name = textBox1.Text;
                    combinetion_Of_Tours.combinetion_of_tours_price = Utils.StringToDecimal(maskedTextBox1.Text);
                    DBWORK.Update();
                    Close();
                    return;
                }
            }
        }

        private void CombinedToursEditForm_Load(object sender, EventArgs e)
        {
            combinetion_Of_Tours = Service_Combination_Of_Tours.UpdateCombinetion_of_tours(id);

            if (changing)
            {
                mainLabel.Text = "Редактирование";
                textBox1.Text = combinetion_Of_Tours.combinetion_of_tours_name;
                maskedTextBox1.Text = Utils.DecimalToString(combinetion_Of_Tours.combinetion_of_tours_price);
            }
            else
            {
                mainLabel.Text = "Добавление";
            }
        }
    }
}
