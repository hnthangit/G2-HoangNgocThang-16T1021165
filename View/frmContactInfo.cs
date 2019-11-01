using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmContactInfo : Form
    {
        string pathContactFile;
        Contact contact;
        public frmContactInfo(Contact contact)
        {
            InitializeComponent();
            pathContactFile = Application.StartupPath + @"\Data\contact.txt";
            this.contact = contact;
            if (contact != null)
            {
                //Chỉnh sửa
                this.Text = "Chỉnh sửa quá trình học tập";
                txtName.Text = contact.Name;
                txtPhone.Text = contact.Phone;
                txtEmail.Text = contact.Email;
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới quá trình học tập";
            }
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if (contact != null)
            {
                //Cập nhật
                var listContact = ContactService.GetAllContact(pathContactFile);
                string newContact = contact.Id + "#" + txtName.Text + "#" + txtPhone.Text + "#" + txtEmail.Text;
                // xóa trong file                
                String deleteOldContact = contact.Id + "#" + contact.Name + "#" + contact.Phone + "#" + contact.Email;
                var Lines = File.ReadAllLines(pathContactFile);
                var newLines = Lines.Where(line => !line.Contains(deleteOldContact));
                File.WriteAllLines(pathContactFile, newLines);
                File.AppendAllText(pathContactFile, newContact);
            }
            else
            {
                //Thêm mới
                var listContact = ContactService.GetAllContact(pathContactFile);
                //Random id moi tu cac id da co
                var exclude = new HashSet<int>();
                foreach (var item in listContact)
                {
                    exclude.Add(Int32.Parse(item.Id));
                }
                var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));
                var rand = new System.Random();
                int index = rand.Next(0, 100 - exclude.Count);

                //Lay id moi
                string newId = range.ElementAt(index).ToString();

                //Tao moi

                string newContact = newId + "#" + txtName.Text + "#" + txtPhone.Text + "#" + txtEmail.Text;
                File.AppendAllText(pathContactFile, "\n" + newContact);
            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");

            //Thuộc tính có sự thay đổi thì form này ngay lập tức sẽ đóng lại
            DialogResult = DialogResult.OK;
        }
    }
}

