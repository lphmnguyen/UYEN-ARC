using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnn = null;
        string strcnn = "Data Source=LAPTOP-QMVLLRQB;Initial Catalog=HANHVUATHOI;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(strcnn);
                cnn.Open();
                MessageBox.Show("ket noi thanh cong");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from Student";
            cmd.Connection = cnn;
            object data = cmd.ExecuteScalar();
            int n = (int)data;
            MessageBox.Show(@"co {n} sinh vien");
        }
    }
}
