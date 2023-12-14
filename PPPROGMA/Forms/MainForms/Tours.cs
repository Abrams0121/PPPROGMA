using PPPROGMA;
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
    public partial class ToursTableForm : Form
    {
        List<Tour> tourslist;
        
        public ToursTableForm()
        {
           
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
            tourslist = ServiceTour.UpdateTour();
            dataGridView2.DataSource = tourslist;
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
            TourConstructorForm tourConstructorForm = new TourConstructorForm()
            {
                changing = false
            };
            tourConstructorForm.ShowDialog();
            tourslist = ServiceTour.UpdateTour();
            dataGridView2.DataSource = tourslist;
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

            ServiceTour DBWORK = new ServiceTour();

            Tour tour = ServiceTour.UpdateTour(id);
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBWORK.delete(tour);
                tourslist = ServiceTour.UpdateTour();
                dataGridView2.DataSource = tourslist;
            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно изменить пустую строку");
                return;
            }
            TourConstructorForm tourConstructorForm = new TourConstructorForm()
            {
                changing = true,
                id = id,
            };
            tourConstructorForm.ShowDialog();
            tourslist = ServiceTour.UpdateTour();
            dataGridView2.DataSource = tourslist;
        }

        private void ToursTableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
