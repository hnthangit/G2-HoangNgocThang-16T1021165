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
    public partial class FormVanBan : Form
    {
        private static FormVanBan _instance = null;
        public static FormVanBan getInstance()
        {
            //Tạo mới và khởi tạo đối tượng duy nhất
            if (_instance == null)
            {
                _instance = new FormVanBan();
            }

            //Return đối tượng duy nhất
            return _instance;
        }

        private FormVanBan()
        {
            InitializeComponent();
        }

        private void FormVanBan_Load(object sender, EventArgs e)
        {
            //Đọc cấu hình chương trình -->appConfig
            //CauHinh appConfig = new CauHinh();
            //appConfig.docTuFile();

            CauHinh appConfig = CauHinh.getInstance();

            //Áp dụng
            this.txtVanBanGoVao.Text = appConfig.getChuoiVanBan();
        }

        private void TxtVanBanGoVao_TextChanged(object sender, EventArgs e)
        {
            lblVanBanHienThi.Text = txtVanBanGoVao.Text;
        }

        private void FormVanBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            CauHinh.getInstance().setChuoiVanBan(this.txtVanBanGoVao.Text);
        }
    }
}
