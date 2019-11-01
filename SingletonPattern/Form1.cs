using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThayDoiMau_Click(object sender, EventArgs e)
        {
            var dlgColor = new ColorDialog();
            if (dlgColor.ShowDialog(this) == DialogResult.OK)
            {
                //Màu mới
                Color mauMoi = dlgColor.Color;

                //Thực hiện đổi màu nền cho panel Shape
                pnlShape.BackColor = dlgColor.Color;

                //Thay đổi nội dung trong file cấu hình
                CauHinh.getInstance().setMauSac(mauMoi);

            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //var frm = new FormVanBan();
            //frm.Show();
            var frm = FormVanBan.getInstance();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Đọc cấu hình chương trình -->appConfig
            //CauHinh appConfig = new CauHinh();
            CauHinh appConfig = CauHinh.getInstance();
            appConfig.docTuFile();

            //Áp dụng cấu hình chương trình (màu cho panel Shape và chữ cho text trong formVanBan)
            this.pnlShape.BackColor = appConfig.getMauSac();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CauHinh.getInstance().luuXuongFile();
        }
    }
}
