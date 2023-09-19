using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sd dialog để mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //chỉ định những file được mở
            openFileDialog.Filter = "Bitmap file|*.bmp|Jpeg|*.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //tạp thể hiện form con và truyền file cho form
                Form2 form2 = new Form2(openFileDialog.FileName);
                form2.MdiParent = this;
                form2.ShowDialog();
                
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
