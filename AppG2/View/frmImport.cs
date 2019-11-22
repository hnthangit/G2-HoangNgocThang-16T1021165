using AppG2.Controller;
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
    public partial class frmImport : Form
    {
        string idUser;
        public frmImport(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filecsv;
            //Mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filecsv = openFileDialog.FileName;
                //Đọc csv file
                //ContactService.ReadFile(filecsv, idUser);
                //Bind lại view
                var contactListNoSort = ContactService.ReadFileData(filecsv, idUser);
                //var newContactList = contactListNoSort.OrderBy(x => x.Name).ToList();
                bdsImport.DataSource = contactListNoSort;
                bdsImport.ResetBindings(true);

            }
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            List<Contact> listContact = bdsImport.DataSource as List<Contact>;
            foreach (var item in listContact)
            {
                var context = new ContactG2Context();
                context.ContactDbSet.Add(item);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
