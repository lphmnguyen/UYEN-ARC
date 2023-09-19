using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmAdd : Form
    {
        frmMain fmain;
        public static int count = 1;
        public frmAdd(frmMain formMain)
        {
            InitializeComponent();
            this.fmain = formMain;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtId, "");
            errorProvider2.SetError(txtName, "");
            errorProvider3.SetError(txtAverageScore, "");
            if(txtId.Text ==""|| txtName.Text == "" || txtAverageScore.Text == "" )
            {
                MessageBox.Show("phai nhap day du thong tin");
                return;
            }

            if(double.Parse(txtAverageScore.Text)  > 10 || double.Parse(txtAverageScore.Text) < 0)
            {
                MessageBox.Show("DTB trong khoang 0-10");
                return;
            }

            DataGridView dataGridView = fmain.dgvData;

            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    if(row.Cells[0].Value == "")
            //    {
            //        break;
            //    }
                
            //    else if (String.Compare(row.Cells[0].Value.ToString(), txtId.Text.ToString(), true) == 0)
            //    {
            //        MessageBox.Show("MSSV da ton tai");
            //    }
            //}


           
            dataGridView.Rows.Add(count,txtId.Text, txtName.Text, cmbFaculty.Text, txtAverageScore.Text);
            count++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
