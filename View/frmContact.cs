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
    public partial class frmContact : Form
    {
        #region Path data file
        string pathContactFile;
        #endregion
        public frmContact()
        {
            InitializeComponent();
            pathContactFile = Application.StartupPath + @"\Data\contact.txt";

            bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;

            var listContactNoSort = ContactService.GetAllContact(pathContactFile);
            var listContact = listContactNoSort.OrderBy(x => x.Name).ToList();
            if (listContact == null)
                throw new Exception("Khong co lien lac nao");
            else
            {
                bdsContact.DataSource = listContact;
            }
            dtgContact.DataSource = bdsContact;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            //var  = (HistoryLearning)bdsQuaTrinhHocTap.Current;
            //var idStudent = hl.IDStudent;
            var f = new frmContactInfo(null); ;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Tiến hành nạp lại dữ liệu lên lưới
                var newContactListNoSort = ContactService.GetAllContact(pathContactFile);
                var newContactList = newContactListNoSort.OrderBy(x => x.Name);
                bdsContact.DataSource = newContactList;
                bdsContact.ResetBindings(true);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var contact = bdsContact.Current as Contact;
            if (contact != null)
            {
                var f = new frmContactInfo(contact);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Tiến hành nạp lại dữ liệu lên lưới
                    var newContactListNoSort = ContactService.GetAllContact(pathContactFile);
                    var newContactList = newContactListNoSort.OrderBy(x => x.Name);
                    bdsContact.DataSource = newContactList;
                    bdsContact.ResetBindings(true);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                //Viết code xóa dữ liệu ở đây
                var contact = (Contact)bdsContact.Current;

                //Lấy toàn bộ nội dung trong bds ra list
                List<Contact> listContact = (List<Contact>)bdsContact.DataSource;
                //Xóa mục đc chọn
                listContact.Remove(contact);

                //set lại bds = list mới
                bdsContact.DataSource = listContact;
                //hiển thị lại bds
                bdsContact.ResetBindings(true);

                // xóa trong file
                String delete = contact.Id + "#" + contact.Name + "#" + contact.Phone + "#" + contact.Email;
                var Lines = File.ReadAllLines(pathContactFile);
                var newLines = Lines.Where(line => !line.Contains(delete));
                File.WriteAllLines(pathContactFile, newLines);
                //Ép kiểu 2 bdsQuaTrinhHocTap.Current as HistoryLearning
                MessageBox.Show("Bạn đã xóa thành công. Name: " + contact.Name);
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var contactListNoSort = ContactService.GetContactBySearch(txtSearch.Text, pathContactFile);
            //var newContactList = contactListNoSort.OrderBy(x => x.Name);
            bdsContact.DataSource = contactListNoSort;
            bdsContact.ResetBindings(true);
        }
    }
}
