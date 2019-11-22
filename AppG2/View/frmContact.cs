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

        #region user
        string idUser;
        #endregion

        public frmContact(String id)
        {
            InitializeComponent();
            pathContactFile = Application.StartupPath + @"\Data\contact.txt";
            idUser = id;
            bdsContact.DataSource = null;
            dtgContact.AutoGenerateColumns = false;

            var listContactNoSort = ContactService.GetAllContact(pathContactFile, idUser);
            var listContact = listContactNoSort.OrderBy(x => x.Name).ToList();
            if (listContact == null)
                throw new Exception("Khong co lien lac nao");
            else
            {
                bdsContact.DataSource = listContact;
            }
            dtgContact.DataSource = bdsContact;
            AddNewLabel();
        }

        public void AddNewLabel()
        {
            flowLayoutPanel1.Controls.Clear();
            List<string> listLabelDuplicate = new List<string>();
            var listContactNoSort = ContactService.GetAllContact(pathContactFile, idUser);

            //Them vao mang cac chu cai dau tien cua name
            foreach (var item in listContactNoSort)
            {
                listLabelDuplicate.Add(item.FirstCharacter);
            }

            //Loai bo cac phan tu trung nhau
            List<String> labels = listLabelDuplicate.Distinct().ToList();

            //Sap xep lai mang
            labels.Sort();

            //Tao label moi 
            for (int i = 0; i < labels.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = labels[i];
                lbl.Click += new System.EventHandler(this.Label_Click);
                flowLayoutPanel1.Controls.Add(lbl);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var f = new frmContactInfo(null, idUser) ;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Tiến hành nạp lại dữ liệu lên lưới
                var newContactListNoSort = ContactService.GetAllContact(pathContactFile, idUser);
                List<Contact> newContactList = newContactListNoSort.OrderBy(x => x.Name).ToList();
                bdsContact.DataSource = newContactList;
                bdsContact.ResetBindings(true);
                AddNewLabel();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var contact = bdsContact.Current as Contact;
            if (contact != null)
            {
                var f = new frmContactInfo(contact, idUser);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Tiến hành nạp lại dữ liệu lên lưới
                    var newContactListNoSort = ContactService.GetAllContact(pathContactFile,idUser);
                    List<Contact> newContactList = newContactListNoSort.OrderBy(x => x.Name).ToList();
                    bdsContact.DataSource = newContactList;
                    bdsContact.ResetBindings(true);
                    AddNewLabel();
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

                var context = new ContactG2Context();
                context.ContactDbSet.Remove(context.ContactDbSet.Find(contact.Id));
                context.SaveChanges();
                //// xóa trong file
                //String delete = contact.Id + "#" + contact.Name + "#" + contact.Phone + "#" + contact.Email;
                //var Lines = File.ReadAllLines(pathContactFile);
                //var newLines = Lines.Where(line => !line.Contains(delete));
                //File.WriteAllLines(pathContactFile, newLines);
                //Ép kiểu 2 bdsQuaTrinhHocTap.Current as HistoryLearning
                MessageBox.Show("Bạn đã xóa thành công. Name: " + contact.Name);
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }

            //Dictionary > Contacts = contacts.GroupBy(x => x.CardName.Substring(0, 1).ToUpper(), (Letter, Contacts) => new { Alphabet = Letter, SubList = Contacts.OrderBy(x => x.CardName).ToList() })
            //    .OrderBy(x => x.Alphabet).ToDictionary(x => x.Alphabet, x => x.SubList);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var contactListNoSort = ContactService.GetContactBySearch(txtSearch.Text, pathContactFile, idUser);
            //var newContactList = contactListNoSort.OrderBy(x => x.Name).ToList();
            bdsContact.DataSource = contactListNoSort;
            bdsContact.ResetBindings(true);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var labelName = ((Label)sender).Text;
            var listContactNoSort = ContactService.GetContactInAlphabetic(labelName, pathContactFile, idUser);
            var newContactList = listContactNoSort.OrderBy(x => x.Name).ToList();
            bdsContact.DataSource = newContactList;
            bdsContact.ResetBindings(true);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void bnImport_Click(object sender, EventArgs e)
        {
            string filecsv;
            //Mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filecsv = openFileDialog.FileName;
                //Đọc csv file
                ContactService.ReadFile(filecsv, idUser);
                //Bind lại view
                var contactListNoSort = ContactService.GetAllContact(pathContactFile, idUser);
                //var newContactList = contactListNoSort.OrderBy(x => x.Name).ToList();
                bdsContact.DataSource = contactListNoSort;
                bdsContact.ResetBindings(true);

            }
            //frmImport frmImport1 = new frmImport(idUser);
            //frmImport1.Show();
        }
    }
}
