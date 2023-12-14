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
    public partial class GeneralServicesTable : Form
    {
        List<General_service> general_Services;

        public GeneralServicesTable()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
            general_Services = ServiceGeneralServices.UpdateGeneral_service();
            dataGridView2.DataSource = general_Services;
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
            GeneralServiceEditForm tourConstructorForm = new GeneralServiceEditForm()
            {
                changing = false
            };
            tourConstructorForm.ShowDialog();
            general_Services = ServiceGeneralServices.UpdateGeneral_service();
            dataGridView2.DataSource = general_Services;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView2.RowCount > 0 ||   !int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно удалить пустую строку");
                return;
            }

            var General_service = ServiceGeneralServices.UpdateGeneral_service(id);
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ServiceGeneralServices DBWORk = new ServiceGeneralServices())
                {
                    DBWORk.delete(General_service);
                }
                general_Services = ServiceGeneralServices.UpdateGeneral_service();
                dataGridView2.DataSource = general_Services;

            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView2.RowCount > 0 || !int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно изменить пустую строку");
                return;
            }
            GeneralServiceEditForm tourConstructorForm = new GeneralServiceEditForm()
            {
                changing = true,
                id = id,
            };
            tourConstructorForm.ShowDialog();
            general_Services = ServiceGeneralServices.UpdateGeneral_service();
            dataGridView2.DataSource = general_Services;
        }
    }
}
