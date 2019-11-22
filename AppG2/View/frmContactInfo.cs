﻿using AppG2.Controller;
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
        string idUser;
        public frmContactInfo(Contact contact, string idUser)
        {
            InitializeComponent();
            pathContactFile = Application.StartupPath + @"\Data\contact.txt";
            this.contact = contact;
            this.idUser = idUser;
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
                var context = new ContactG2Context();
                var newContact = context.ContactDbSet.Single(b => b.Id == contact.Id);
                newContact.Name = txtName.Text;
                newContact.Phone = txtPhone.Text;
                newContact.Email = txtEmail.Text;
                context.SaveChanges();
                //var listContact = ContactService.GetAllContact(pathContactFile);
                //string newContact = contact.Id + "#" + txtName.Text + "#" + txtPhone.Text + "#" + txtEmail.Text;
                //// xóa trong file                
                //String deleteOldContact = contact.Id + "#" + contact.Name + "#" + contact.Phone + "#" + contact.Email;
                //var Lines = File.ReadAllLines(pathContactFile);
                //var newLines = Lines.Where(line => !line.Contains(deleteOldContact));
                //var temp = newLines.ToList();
                //temp.Add(newContact);
                //newLines = temp as IEnumerable<string>;
                //File.WriteAllLines(pathContactFile, newLines);
            }
            else
            {
                //Thêm mới
                var listContact = ContactService.GetAllContact(pathContactFile, idUser);
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

                var context = new ContactG2Context();
                context.ContactDbSet.Add(new Contact
                {
                    Id = newId,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    IdUser = idUser
                }) ;
                context.SaveChanges();

            ////Tao moi
            //string newContact = newId + "#" + txtName.Text + "#" + txtPhone.Text + "#" + txtEmail.Text;
            ////File.AppendAllText(pathContactFile, Environment.NewLine+ newContact );
            //List<string> temp = new List<string>();
            //temp.Add(newContact);
            //var newLine = temp as IEnumerable<string>;
            //File.AppendAllLines(pathContactFile, newLine);
        }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");

            //Thuộc tính có sự thay đổi thì form này ngay lập tức sẽ đóng lại
            DialogResult = DialogResult.OK;
        }
    }
}

