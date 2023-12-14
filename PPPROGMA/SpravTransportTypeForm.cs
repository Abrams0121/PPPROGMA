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
    public partial class SpravTransportTypeForm : Form
    {

        List<Sprav_transport_type> sprav_Transport_Types; 
        
        public SpravTransportTypeForm()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
            sprav_Transport_Types = Read.UpdateTranportType();
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
            SpravTransportTypeEditForm frm = new SpravTransportTypeEditForm();
            frm.ShowDialog();
            sprav_Transport_Types = Read.UpdateTranportType();
            dataGridView2.DataSource = sprav_Transport_Types;
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
            

            var type = Service_sprav_transport_type.UpdateTransport(int.Parse(dataGridView2.CurrentRow.Cells["id"].Value.ToString()));
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Service_sprav_transport_type BDWORK = new Service_sprav_transport_type())
                {
                    BDWORK.delete(type);
                }
                sprav_Transport_Types = Read.UpdateTranportType();
                dataGridView2.DataSource = sprav_Transport_Types;
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
            SpravTransportTypeEditForm frm = new SpravTransportTypeEditForm()
            {
                changing = true,
                index = id
            };
            frm.ShowDialog();
            
            sprav_Transport_Types = Read.UpdateTranportType();
            dataGridView2.DataSource = sprav_Transport_Types;
        }

        private void SpravTransportTypeForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = sprav_Transport_Types;
        }
    }
}
