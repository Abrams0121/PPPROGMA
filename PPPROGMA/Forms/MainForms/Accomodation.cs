using PPPROGMA.Classes.CRUD.Service;
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
    public partial class AccomodationForm : Form
    {
        List<Accommodation> accommodations;

        public AccomodationForm()
        {
            InitializeComponent();
            accommodations = ServiceAccomodation.UpdateAccommodation();
            dataGridView2.DataSource = accommodations;
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
            AccomodationEditForm accomodationEditForm = new AccomodationEditForm();
            accomodationEditForm.ShowDialog();
            accommodations = ServiceAccomodation.UpdateAccommodation();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно удалить пустую строку");
                return;
            }
            ServiceAccomodation BDWORK = new ServiceAccomodation();

            var accomodation = ServiceAccomodation.UpdateAccommodation(int.Parse(dataGridView2.CurrentRow.Cells["id"].Value.ToString()));
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BDWORK.delete(accomodation);
                accommodations = ServiceAccomodation.UpdateAccommodation();
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно удалить пустую строку");
                return;
            }

            AccomodationEditForm accomodationEditForm = new AccomodationEditForm()
            {
                changing = true,
                id = id
            };
            accomodationEditForm.ShowDialog();
            accommodations = ServiceAccomodation.UpdateAccommodation();
        }

        private void AccomodationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
