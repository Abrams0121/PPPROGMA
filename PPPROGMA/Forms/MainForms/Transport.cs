using PPPROGMA.Classes.CRUD;
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
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    
    public partial class TransportTable : Form
    {
        List<Transport> transports;

        public TransportTable()
        {
            InitializeComponent();
            transports = Program.BD.transports.Include(x => x.Sprav_Transport_type).ToList();
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
            TransportEditForm frm = new TransportEditForm();
            frm.ShowDialog();
            transports = Program.BD.transports.ToList();
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
            ServiceTransport BDWORK = new ServiceTransport();


            var transport = Program.BD.transports.FirstOrDefault(x => x.idTransport == int.Parse(dataGridView2.CurrentRow.Cells["id"].Value.ToString()));
            string text = "Вы уверены что хотите удалить запись?";
            if (MessageBox.Show(text, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BDWORK.delete(transport);
                transports = Program.BD.transports.ToList();
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
            TransportEditForm frm = new TransportEditForm()
            {
                changing = true,
                id = id
            };
            frm.ShowDialog();
            transports = Program.BD.transports.ToList();
        }
    }
}
