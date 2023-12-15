using PPPROGMA;
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
    public partial class CombinedToursTable : Form
    {
        List<Combinetion_of_tours> combinetion_Of_Tours;
        public CombinedToursTable()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
            combinetion_Of_Tours = Service_Combination_Of_Tours.UpdateCombinetion_of_tours();
            dataGridView2.DataSource = combinetion_Of_Tours;
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
            CombinedToursEditForm tourConstructorForm = new CombinedToursEditForm();
            tourConstructorForm.ShowDialog();
            combinetion_Of_Tours = Service_Combination_Of_Tours.UpdateCombinetion_of_tours();
            dataGridView2.DataSource = combinetion_Of_Tours;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView2.RowCount == 0 || !int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно удалить пустую строку");
                return;
            }

            var General_service = Service_Combination_Of_Tours.UpdateCombinetion_of_tours(id);
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Service_Combination_Of_Tours DBWORk = new Service_Combination_Of_Tours())
                {
                    DBWORk.delete(General_service);
                }
                combinetion_Of_Tours = Service_Combination_Of_Tours.UpdateCombinetion_of_tours();
                dataGridView2.DataSource = combinetion_Of_Tours;

            }


        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int id;
            if (dataGridView2.RowCount == 0 || !int.TryParse(dataGridView2.CurrentRow.Cells["id"].Value.ToString(), out id))
            {
                Utils.Error("Невозможно изменить пустую строку");
                return;
            }
            CombinedToursEditForm tourConstructorForm = new CombinedToursEditForm()
            {
                changing = true,
                id = id,
            };
            tourConstructorForm.ShowDialog();
            combinetion_Of_Tours = Service_Combination_Of_Tours.UpdateCombinetion_of_tours();
            dataGridView2.DataSource = combinetion_Of_Tours;
        }
    }
}
