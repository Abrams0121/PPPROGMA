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

        public int tourId;

        int selectedDay;

        Tour tour;
        List<Tour_days> days_list;

        List<Accommodation> accommodations;
        List<Combinetion_of_tours> combinetion_Of_Tours;
        List<General_service> general_Services;
        List<Service> services;
        List<Food> foods;
        List<Transport> transports;
        public TourConstructorForm()
        {
            InitializeComponent();
            accomodationDataGridView.AutoGenerateColumns = false;
            combinedToursDataGridView.AutoGenerateColumns = false;
            generalServicesDataGridView.AutoGenerateColumns = false;
            serviceDataGridView.AutoGenerateColumns = false;
            foodDataGridView.AutoGenerateColumns = false;
            transportDataGridView.AutoGenerateColumns = false;
            tourDaysDataGridView.AutoGenerateColumns = false;
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
                tour = ServiceTour.UpdateTour(tourId);

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
                using(ServiceTour DBWORK = new ServiceTour())
                {
                    DBWORK.Insert(tour);
                }
                Tour_days tour_Days = new Tour_days()
                {
                    idTour = tour.idTours,
                    Day_number = 1,
                    idAccommodation = 0
                };
                using (ServiceDayTour DBWORk = new ServiceDayTour())
                {
                    DBWORk.Insert(tour_Days);
                }
                using (ServiceList DBWORk = new ServiceList())
                {
                    days_list = DBWORk.UpdateDaysListWithTour(tour.idTours);
                }

                mainLabel.Text = "Добавление";
            }
            tourDaysDataGridView.DataSource = days_list;

            UpdateAllTables();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tour_days tour_Days = new Tour_days()
            {
                idTour = tourId,
                Day_number = ServiceDayTour.Max(tourId) + 1
            };
            using (ServiceDayTour DBWORk = new ServiceDayTour())
            {
                DBWORk.Insert(tour_Days);
            }
            using (ServiceList DBWORk = new ServiceList())
            {
                days_list = DBWORk.UpdateDaysListWithTour(tour.idTours);
            }
            tourDaysDataGridView.DataSource = days_list;
            UpdateAllTables();
        }

        private void tourDaysDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            SelectListForm<Combinetion_of_tours> selectListForm = new SelectListForm<Combinetion_of_tours>();

            selectListForm.ShowDialog();
            if (!selectListForm.changed)
            {
                return;
            }
            Combinetion_of_tours_list combList = new Combinetion_of_tours_list()
            {
                idTour_days = id,
                idCombinetion_Of_Tours = selectListForm.id
            };
            using (ServiceList DBWORK = new ServiceList())
            {
                DBWORK.Insert(combList);
            }
            UpdateAllTables();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int id;
            if (combinedToursDataGridView.RowCount == 0 || !int.TryParse(combinedToursDataGridView.CurrentRow.Cells["ComToursIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceList DBWORK = new ServiceList())
            {
                var com = DBWORK.GetEntity<Combinetion_of_tours_list>(id);
                DBWORK.Delete(com);
            }
            UpdateAllTables();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            SelectListForm<Accommodation> selectListForm = new SelectListForm<Accommodation>();

            selectListForm.ShowDialog();
            if (!selectListForm.changed)
            {
                return;
            }
            using (ServiceDayTour DBWORK = new ServiceDayTour())
            {
                var day = DBWORK.ForUpdateServicet(id);
                day.idAccommodation = selectListForm.id;
                DBWORK.Update();
            }
            UpdateAllTables();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int id;
            if (accomodationDataGridView.RowCount == 0 || !int.TryParse(accomodationDataGridView.CurrentRow.Cells["AccomodationIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceDayTour DBWORK = new ServiceDayTour())
            {
                var day = DBWORK.ForUpdateServicet(id);
                day.idAccommodation = 0;
                DBWORK.Update();
            }
            UpdateAllTables();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            SelectListForm<Transport> selectListForm = new SelectListForm<Transport>();

            selectListForm.ShowDialog();
            if (!selectListForm.changed)
            {
                return;
            }
            Transport_list TranList = new Transport_list()
            {
                idTour_days = id,
                idTransport = selectListForm.id
            };
            using (ServiceList DBWORK = new ServiceList())
            {
                DBWORK.Insert(TranList);
            }
            UpdateAllTables();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id;
            if (transportDataGridView.RowCount == 0 || !int.TryParse(transportDataGridView.CurrentRow.Cells["TransportIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceList DBWORK = new ServiceList())
            {
                var com = DBWORK.GetEntity<Transport_list>(id);
                DBWORK.Delete(com);
            }
            UpdateAllTables();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            SelectListForm<Service> selectListForm = new SelectListForm<Service>();

            selectListForm.ShowDialog();
            if (!selectListForm.changed)
            {
                return;
            }
            Services_list SerList = new Services_list()
            {
                idTour_days = id,
                idServices = selectListForm.id
            };
            using (ServiceList DBWORK = new ServiceList())
            {
                DBWORK.Insert(SerList);
            }
            UpdateAllTables();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id;
            if (serviceDataGridView.RowCount == 0 || !int.TryParse(serviceDataGridView.CurrentRow.Cells["ServiceIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceList DBWORK = new ServiceList())
            {
                var com = DBWORK.GetEntity<Services_list>(id);
                DBWORK.Delete(com);
            }
            UpdateAllTables();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            SelectListForm<General_service> selectListForm = new SelectListForm<General_service>();

            selectListForm.ShowDialog();
            if (!selectListForm.changed)
            {
                return;
            }
            General_service_list genSerList = new General_service_list()
            {
                idTour_days = id,
                idGeneral_Service = selectListForm.id,
                general_service_listcol_count = selectListForm.count
            };
            using (ServiceList DBWORK = new ServiceList())
            {
                DBWORK.Insert(genSerList);
            }
            UpdateAllTables();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int id;
            if (generalServicesDataGridView.RowCount == 0 || !int.TryParse(generalServicesDataGridView.CurrentRow.Cells["GeneralServiceIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceList DBWORK = new ServiceList())
            {
                var com = DBWORK.GetEntity<General_service_list>(id);
                DBWORK.Delete(com);
            }
            UpdateAllTables();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            FoodAddForm foodAddForm = new FoodAddForm()
            {
                id = id
            };
            foodAddForm.ShowDialog();
            UpdateAllTables();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            var day = ServiceDayTour.UpdateService(id);
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ServiceDayTour DBWORk = new ServiceDayTour())
                {
                    DBWORk.delete(day);
                }
                UpdateAllTables();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            if (foodDataGridView.RowCount == 0 || !int.TryParse(foodDataGridView.CurrentRow.Cells["FoodIndex"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            using (ServiceList DBWORK = new ServiceList())
            {
                var com = DBWORK.GetEntity<Food_list>(id);
                DBWORK.Delete(com);
            }
            UpdateAllTables();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextInputForm textInputForm = new TextInputForm()
            {
                str = textBox1.Text
            };
            textInputForm.ShowDialog();
            textBox1.Text = textInputForm.str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            if (checkBox1.Checked)
            {
                startDate = DateTime.Now;
            }
            else
            {
                startDate = dateTimePicker1.Value;
            }
            using (ServiceTour DBWORk = new ServiceTour())
            {
                decimal cost_marja = 0;
                decimal cost_per_one = 0;
                decimal profit = 0;
                Tour tour = DBWORk.ForUpdateTour(tourId);
                tour.Tour_Name = textBox1.Text;
                tour.Tour_start_date = startDate;
                tour.Tourist_Count = Convert.ToInt32(numericUpDown1.Value);
                tour.Tour_Cost_No_Marja = Utils.CalcBase(tourId, tour.Tourist_Count, out cost_marja,
                    out cost_per_one, out profit);
                tour.Tour_Cost_marja = cost_marja;
                tour.Tour_cost_For_one_person = cost_per_one;
                tour.Tour_Profit = profit;
                DBWORk.Update();
            }
            Close();
        }

        private void UpdateAllTables()
        {
            int id;
            if (!int.TryParse(tourDaysDataGridView.CurrentRow.Cells["Index"].Value.ToString(), out id))
            {
                Utils.Error("Ошибка выборки");
                return;
            }
            foodDataGridView.DataSource = ServiceList.Updatefood_Lists(id);
            transportDataGridView.DataSource = ServiceList.UpdateTransport_list(id);
            serviceDataGridView.DataSource = ServiceList.UpdateServices_list(id);
            generalServicesDataGridView.DataSource = ServiceList.UpdateGeneral_service_List(id);
            combinedToursDataGridView.DataSource = ServiceList.UpdateCombinetion_of_tours_List(id);
            using (ServiceList DBWORk = new ServiceList())
            {
                days_list = DBWORk.UpdateAccomodation(id);
            }
            accomodationDataGridView.DataSource = days_list;
        }

        private void tourDaysDataGridView_Click(object sender, EventArgs e)
        {
            UpdateAllTables();
        }
    }
}
