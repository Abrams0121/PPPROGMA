using PPPROGMA;
using PPPROGMA.Classes.CRUD.Service;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TourConstructorForm : Form
    {
        public bool changing;

        public int id;

        Tour tour;
        List<Tour_days> days_list;

        List<Accommodation> accommodations;
        List<Combinetion_of_tours> combinetion_Of_Tours;
        List<General_service> general_Services;
        List<Service> services;
        public TourConstructorForm()
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

        private void TourConstructorForm_Load(object sender, EventArgs e)
        {

            if (changing)
            {
                tour = ServiceTour.UpdateTour(id);

                using (ServiceList DBWORk = new ServiceList())
                {
                    days_list = DBWORk.UpdateDaysListWithTour(tour.idTours);
                }
                mainLabel.Text = "Редактирование";
                textBox1.Text = tour.Tour_Name;
                dateTimePicker1.Text = tour.Tour_start_date.ToString();
            }
            else
            {
                tour = new Tour();
                Tour_days tour_Days = new Tour_days()
                {
                    idTour = id,
                    Day_number = 1
                };

                using (ServiceList DBWORk = new ServiceList())
                {
                    days_list = DBWORk.UpdateDaysListWithTour(tour.idTours);
                }

                mainLabel.Text = "Добавление";
            }
            tourDaysDataGridView.DataSource = days_list;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
