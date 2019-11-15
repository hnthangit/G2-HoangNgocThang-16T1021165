using SimpleFactoryPattern.Controller;
using SimpleFactoryPattern.Datasource;
using SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnDb_Click(object sender, EventArgs e)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            DatasourceFactory datasourceFactory = new DatasourceFactory();
            var sql = datasourceFactory.CreateDatasource("SQL");
            listSinhVien = sql.GetAll();
            foreach (var item in listSinhVien)
            {
                Console.WriteLine("Ma sv: {0}, Ten sv: {1}", item.Id, item.Name);
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            listSinhVien = SinhVienController.GetSinhVienFromFile();
            foreach (var item in listSinhVien)
            {
                Console.WriteLine("Ma sv: {0}, Ten sv: {1}", item.Id, item.Name);
            }
        }
    }
}
