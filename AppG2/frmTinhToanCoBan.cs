using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2
{
    public partial class frmTinhToanCoBan : Form
    {
        public frmTinhToanCoBan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                errProvider.Clear();
                float temp = 0;
                if(!float.TryParse(txtA.Text, out temp))
                {
                    //MessageBox.Show("Vui long nhap lai gia tri a la so");
                    errProvider.SetError(txtA,"Vui long nhap lai gia tri a la so");
                    return;
                }

                var a = float.Parse(txtA.Text);

                if (!float.TryParse(txtB.Text, out temp))
                {
                    //MessageBox.Show("Vui long nhap lai gia tri b la so");
                    errProvider.SetError(txtB,"Vui long nhap lai gia tri b la so");
                    return;
                }
                
                var b = float.Parse(txtB.Text);

                var c = a + b;
                string data = String.Format("{0} + {1} = {2}", a, b, c);
                MessageBox.Show(data, "Ket qua", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Loi, Chi tiet: " + ex.StackTrace);
            }
        }
    }
}
