using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new ContactG2Context();
            var user = context.UserDbSet.Where(b => (b.Username == txtusername.Text && b.Password == txtpassword.Text)).FirstOrDefault();
            if (user != null)
            {
                var frmContact = new frmContact(user.IdUser);
                this.Hide();
                //Đóng form khi mở ra 1 form mới
                if(frmContact.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
                frmContact.Show();
                
            }
        }
    }
}
