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
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SpravTransportTypeForm spravTransportTypeForm = new SpravTransportTypeForm();
            spravTransportTypeForm.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            TransportTable transportTable = new TransportTable();
            transportTable.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CombinedToursTable combinedToursTable = new CombinedToursTable();
            combinedToursTable.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            GeneralServicesTable generalServicesTable = new GeneralServicesTable();
            generalServicesTable.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ServiceTable serviceTable = new ServiceTable();
            serviceTable.ShowDialog();
        }

        private void проживаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccomodationForm accomodationForm = new AccomodationForm();
            accomodationForm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToursTableForm toursTable = new ToursTableForm();
            toursTable.ShowDialog();
        }
    }
}
